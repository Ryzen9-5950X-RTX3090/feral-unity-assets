using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using VivoxUnity;

public class FeralVivoxManager : SingletonManagerBase<FeralVivoxManager>
{
	public enum ChangedProperty
	{
		None,
		Speaking,
		Typing,
		Muted
	}

	public enum ChatCapability
	{
		TextOnly,
		AudioOnly,
		TextAndAudio
	}

	public delegate void ParticipantValueChangedHandler(ObscuredString username, ChannelId channel, ObscuredBool value);

	public delegate void ParticipantValueUpdatedHandler(ObscuredString username, ChannelId channel, ObscuredDouble value);

	public delegate void ParticipantStatusChangedHandler(ObscuredString username, ChannelId channel, IParticipant participant);

	public delegate void ChannelTextMessageChangedHandler(ObscuredString sender, IChannelTextMessage channelTextMessage);

	public delegate void LoginStatusChangedHandler();

	public delegate void OnCallHandler(ObscuredBool value);

	public delegate void OnMuteHandler(ObscuredString username);

	public enum EChatMessage
	{
		NONE,
		INVITE,
		ACCEPTED,
		DECLINED,
		ALREADYINGROUP,
		CANJOIN,
		CANJOINYES,
		CANJOINNO_CHANNELCLOSED,
		CANJOINNO_FULLGROUP,
		PRIVACYDISABLED,
		PRIVACYFOLLOWERS
	}

	[Serializable]
	public class TempChatMessage
	{
		public ObscuredString uuid;

		public ObscuredString displayName;

		public ObscuredString channel;

		public EChatMessage message;

		public TempChatMessage(ObscuredString inDisplayName, ObscuredString inUUID, ObscuredString inChannel, EChatMessage inMessage)
		{
		}
	}

	[Serializable]
	public class VivoxInfo
	{
		public ObscuredString server;

		public ObscuredString domain;

		public ObscuredString tokenIssuer;

		public ObscuredString tokenKey;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <KeepAlive>d__129 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public FeralVivoxManager <>4__this;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SrvRequestNewCall>d__131 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inUUID;

		private UniTask<VoiceChatServiceRequests.VoiceChatCallGetResponse>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SrvRequestCallAttendees>d__132 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private UniTask<VoiceChatServiceRequests.VoiceChatGetAttendeesResponse>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SrvRequestLeaveCall>d__133 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private UniTask<VoiceChatServiceRequests.VoiceChatLeaveCallGetResponse>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Blocked>d__136 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public string inUUID;

		public Action<bool> aBlocked;

		private UniTask<bool>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SendRequestDirectGenericMessage_NotSecureAsync>d__147 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public FeralVivoxManager <>4__this;

		public ObscuredString inDisplayName;

		public ObscuredString inUUID;

		public EChatMessage inMessage;

		private <>c__DisplayClass147_0 <>8__1;

		public ObscuredString inChannel;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SrvRequestAddPlayer>d__148 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public string inUUID;

		public FeralVivoxManager <>4__this;

		public Action<ObscuredString> callback;

		private UniTask<VoiceChatServiceRequests.VoiceChatInvitePlayerGetResponse>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <MuteIfBlocked>d__166 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public IParticipant inParticipant;

		public FeralVivoxManager <>4__this;

		private UniTask<bool>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	[Header("Localization")]
	[RootSelector("Title - Blocked", "LocalizationChartData", false, false)]
	private string _locTitleBlocked;

	[SerializeField]
	[RootSelector("Description - Blocked", "LocalizationChartData", false, false)]
	private string _locDescBlocked;

	[SerializeField]
	[RootSelector("Ok", "LocalizationChartData", false, false)]
	private string _locOk;

	[SerializeField]
	[RootSelector("Yes", "LocalizationChartData", false, false)]
	private string _locYes;

	[SerializeField]
	[RootSelector("No", "LocalizationChartData", false, false)]
	private string _locNo;

	[SerializeField]
	[RootSelector("Title - Wait", "LocalizationChartData", false, false)]
	private string _locTitleWait;

	[SerializeField]
	[RootSelector("Description - Wait", "LocalizationChartData", false, false)]
	private string _locDescWait;

	[SerializeField]
	[RootSelector("Title - Invite Sent", "LocalizationChartData", false, false)]
	private string _locTitleInviteSent;

	[SerializeField]
	[RootSelector("Description - Invite Sent", "LocalizationChartData", false, false)]
	private string _locDescInviteSent;

	[SerializeField]
	[RootSelector("Description - Already in your group", "LocalizationChartData", false, false)]
	private string _locDescAlreadyInYourGroup;

	[SerializeField]
	[RootSelector("Title - Already in group", "LocalizationChartData", false, false)]
	private string _locTitleAlreadyInGroup;

	[SerializeField]
	[RootSelector("Description - Already in group", "LocalizationChartData", false, false)]
	private string _locDescAlreadyInGroup;

	[SerializeField]
	[RootSelector("Title - Invite", "LocalizationChartData", false, false)]
	private string _locTitleInvite;

	[SerializeField]
	[RootSelector("Description - Invite", "LocalizationChartData", false, false)]
	private string _locDescInvite;

	[SerializeField]
	[RootSelector("Title - Group Not Found", "LocalizationChartData", false, false)]
	private string _locTitleGroupNotFound;

	[SerializeField]
	[RootSelector("Description - Group Not Found", "LocalizationChartData", false, false)]
	private string _locDescGroupNotFound;

	[SerializeField]
	[RootSelector("Title - Full Group", "LocalizationChartData", false, false)]
	private string _locTitleFullGroup;

	[SerializeField]
	[RootSelector("Description - Full Group", "LocalizationChartData", false, false)]
	private string _locDescFullGroup;

	[SerializeField]
	[RootSelector("Description - Full Group Invite", "LocalizationChartData", false, false)]
	private string _locDescFullGroupInvite;

	[SerializeField]
	[RootSelector("Title - Followers Only", "LocalizationChartData", false, false)]
	private string _locTitleFollowersOnly;

	[SerializeField]
	[RootSelector("Description - Followers Only", "LocalizationChartData", false, false)]
	private string _locDescFollowersOnly;

	[SerializeField]
	[RootSelector("Title - Disabled", "LocalizationChartData", false, false)]
	private string _locTitleDisabled;

	[SerializeField]
	[RootSelector("Description - Disabled WildWorks", "LocalizationChartData", false, false)]
	private string _locDescDisabledWildWorks;

	[SerializeField]
	[RootSelector("Description - Disabled Settings", "LocalizationChartData", false, false)]
	private string _locDescDisabledSettings;

	[SerializeField]
	[RootSelector("Description - Disabled Privacy", "LocalizationChartData", false, false)]
	private string _locDescDisabledPrivacy;

	[SerializeField]
	[RootSelector("Title - Mic Disabled", "LocalizationChartData", false, false)]
	private string _locTitleMicDisabled;

	[SerializeField]
	[RootSelector("Description - Mic Disabled - iOS", "LocalizationChartData", false, false)]
	private string _locDescMicDisabled_iOS;

	[SerializeField]
	[RootSelector("Description - Mic Disabled - Android", "LocalizationChartData", false, false)]
	private string _locDescMicDisabled_Android;

	[SerializeField]
	[RootSelector("Description - Mic Disabled", "LocalizationChartData", false, false)]
	private string _locDescMicDisabled;

	private DateTime? _dateChannelStarted;

	private DateTime? _focusedTime;

	private DateTime? _unfocusedTime;

	private List<ObscuredString> _groupInviteList;

	[SerializeField]
	private ObscuredInt _groupInviteTimer;

	[SerializeField]
	private VivoxInfo _vivoxDevelopment;

	[SerializeField]
	private VivoxInfo _vivoxProduction;

	private TimeSpan _tokenExpiration;

	private Client _client;

	private AccountId _accountId;

	private bool _quitting;

	public ILoginSession loginSession;

	private IChannelSession _currentChannelSession;

	private ChannelId _priorChannelId;

	private ObscuredString _channelIdName;

	private ObscuredBool _vivoxEnabled;

	private ObscuredInt _maxVoiceChatParticipants;

	private ObscuredString _personalChannelID;

	private TransmissionMode _transmissionMode;

	private string _vivoxVoiceVolume;

	private float? _voiceVolume;

	public ObscuredBool onCall
	{
		[CompilerGenerated]
		get
		{
			return default(ObscuredBool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private Uri _serverUri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private VivoxInfo vivoxInfo
	{
		get
		{
			return null;
		}
	}

	public TimeSpan tokenExpiration
	{
		get
		{
			return default(TimeSpan);
		}
	}

	public LoginState loginState
	{
		[CompilerGenerated]
		get
		{
			return default(LoginState);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public VivoxUnity.IReadOnlyDictionary<ChannelId, IChannelSession> ActiveChannels
	{
		get
		{
			return null;
		}
	}

	public IAudioDevices audioInputDevices
	{
		get
		{
			return null;
		}
	}

	public IAudioDevices audioOutputDevices
	{
		get
		{
			return null;
		}
	}

	public ChannelId currentChannelId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public ObscuredString channelIdName
	{
		get
		{
			return null;
		}
	}

	public ObscuredInt maxVoiceChatParticipants
	{
		get
		{
			return default(ObscuredInt);
		}
	}

	public float VoiceVolume
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public IChannelSession TransmittingSession
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event ParticipantValueChangedHandler OnSpeechDetectedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ParticipantValueUpdatedHandler OnAudioEnergyChangedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ParticipantStatusChangedHandler OnParticipantAddedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ParticipantStatusChangedHandler OnParticipantRemovedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ChannelTextMessageChangedHandler OnTextMessageLogReceivedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event LoginStatusChangedHandler OnUserLoggedInEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event LoginStatusChangedHandler OnUserLoggedOutEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OnCallHandler OnCallEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OnMuteHandler OnMuteEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private ChannelId CreateGroupChannel(ObscuredString inChannelName)
	{
		return null;
	}

	private ObscuredString GetPersonalChannelId(bool inReset = false)
	{
		return null;
	}

	public ObscuredString GetClientID(bool inUseDisplayName = false)
	{
		return null;
	}

	public override void MStart()
	{
	}

	private void OnLoginComplete(LoginCompleteMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<KeepAlive>d__129))]
	private void KeepAlive()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	[AsyncStateMachine(typeof(<SrvRequestNewCall>d__131))]
	private void SrvRequestNewCall(string inUUID)
	{
	}

	[AsyncStateMachine(typeof(<SrvRequestCallAttendees>d__132))]
	private void SrvRequestCallAttendees(string inUUID)
	{
	}

	[AsyncStateMachine(typeof(<SrvRequestLeaveCall>d__133))]
	private void SrvRequestLeaveCall()
	{
	}

	public override void MUpdate()
	{
	}

	public ObscuredBool UnderMaxLimit()
	{
		return default(ObscuredBool);
	}

	[AsyncStateMachine(typeof(<Blocked>d__136))]
	private UniTask Blocked(string inUUID, Action<bool> aBlocked)
	{
		return default(UniTask);
	}

	public void OnReceivedDirectGenericMessage(ReceivedDirectGenericMessageMessage inMessage)
	{
	}

	[IteratorStateMachine(typeof(<AskForPermission>d__138))]
	private IEnumerator AskForPermission(Action<bool> callBack)
	{
		return null;
	}

	private void PermissionGranted(string inString)
	{
	}

	private void PermissionDenied(string inString)
	{
	}

	private void PermissionDeniedAndDontAskAgain(string inString)
	{
	}

	private void FindMicrophones()
	{
	}

	public bool CheckVoiceChatDisabled()
	{
		return default(bool);
	}

	public void SendInviteToChannel(ObscuredString inUUID, ObscuredString inDisplayName)
	{
	}

	[IteratorStateMachine(typeof(<SendInviteToChannelCoroutine>d__145))]
	private IEnumerator SendInviteToChannelCoroutine(ObscuredString inUUID, ObscuredString inDisplayName)
	{
		return null;
	}

	private void SendRequestDirectGenericMessage_NotSecure(ObscuredString inUUID, ObscuredString inDisplayName, ObscuredString inChannel, EChatMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<SendRequestDirectGenericMessage_NotSecureAsync>d__147))]
	private void SendRequestDirectGenericMessage_NotSecureAsync(ObscuredString inUUID, ObscuredString inDisplayName, ObscuredString inChannel, EChatMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<SrvRequestAddPlayer>d__148))]
	private UniTask SrvRequestAddPlayer(string inUUID, Action<ObscuredString> callback)
	{
		return default(UniTask);
	}

	private void OkPopup(string inTitle, string inMessage)
	{
	}

	[IteratorStateMachine(typeof(<RemoveFromGroupInviteList>d__150))]
	private IEnumerator RemoveFromGroupInviteList(string inDisplayName)
	{
		return null;
	}

	public void SendRequestDirectGenericMessage(ObscuredString inUUID, TempChatMessage inTempChatMessage)
	{
	}

	private void VoiceVolumeChanged(float inVolume)
	{
	}

	public void CreateVoiceChatGroup([Optional] ObscuredString inChannelName)
	{
	}

	public void LeaveVoiceChatGroup()
	{
	}

	[IteratorStateMachine(typeof(<LoginToVivox>d__155))]
	private IEnumerator LoginToVivox()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<ReleaseChannel>d__156))]
	private IEnumerator ReleaseChannel()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<CreateVoiceChatGroupCoroutine>d__157))]
	private IEnumerator CreateVoiceChatGroupCoroutine(ObscuredString inChannelName)
	{
		return null;
	}

	private void OnApplicationQuit()
	{
	}

	private void LoginUser([Optional] string displayName)
	{
	}

	private void Logout()
	{
	}

	private void DisconnectAllChannels()
	{
	}

	private void OnMessageLogRecieved(object sender, QueueItemAddedEventArgs<IChannelTextMessage> textMessage)
	{
	}

	private void OnLoginSessionPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
	{
	}

	public void SetAudioDevices([Optional] IAudioDevice targetInput, [Optional] IAudioDevice targetOutput)
	{
	}

	private void OnParticipantAdded(object sender, KeyEventArg<string> keyEventArg)
	{
	}

	[AsyncStateMachine(typeof(<MuteIfBlocked>d__166))]
	private void MuteIfBlocked(IParticipant inParticipant)
	{
	}

	public void MuteMyself()
	{
	}

	public ObscuredBool AmIMuted()
	{
		return default(ObscuredBool);
	}

	public ObscuredBool IsPlayerMuted(string inTargetId)
	{
		return default(ObscuredBool);
	}

	public void MuteOtherUser(ObscuredString inTargetId, ObscuredBool inMute)
	{
	}

	public void MuteOtherUser(string inTargetId)
	{
	}

	public void AddPlayerToGroupChat()
	{
	}

	private void OnParticipantRemoved(object sender, KeyEventArg<string> keyEventArg)
	{
	}

	private static void ValidateArgs(object[] objs)
	{
	}

	private void OnParticipantValueUpdated(object sender, ValueEventArg<string, IParticipant> valueEventArg)
	{
	}

	private void OnChannelPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
	{
	}

	public VivoxUnity.IReadOnlyDictionary<string, IParticipant> GetParticipants()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void OnQuitting()
	{
	}

	private void LogoutOfVivoxService()
	{
	}

	public void LoginToVivox(string inName)
	{
	}

	private void JoinChannel(ObscuredString inChannelName)
	{
	}

	private void OnCallUpdate()
	{
	}

	private void SourceOnChannelPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
	{
	}

	private void LeaveChannel()
	{
	}

	private void OnUserLoggedIn()
	{
	}

	private void OnUserLoggedOut()
	{
	}

	private void Log(object inLog)
	{
	}

	private void LogError(object inLog)
	{
	}
}
