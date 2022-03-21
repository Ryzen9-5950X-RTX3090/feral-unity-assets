using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using VivoxUnity.Common;

namespace VivoxUnity.Private
{
	internal class LoginSession : ILoginSession, IKeyedItemNotifyPropertyChanged<AccountId>, INotifyPropertyChanged
	{
		private readonly string _accountHandle;

		private readonly string _groupHandle;

		private readonly Client _client;

		private LoginState _state;

		private TransmissionMode _transmissionType;

		private bool _isInjectingAudio;

		private readonly ReadWriteDictionary<ChannelId, IChannelSession, ChannelSession> _channelSessions;

		private ChannelId _transmittingChannel;

		private List<ChannelId> _channelsToDelete;

		private Timer _deleteTimer;

		private readonly ReadWriteHashSet<AccountId> _blockedSubscriptions;

		private readonly ReadWriteHashSet<AccountId> _allowedSubscriptions;

		private readonly ReadWriteDictionary<AccountId, IPresenceSubscription, PresenceSubscription> _presenceSubscriptions;

		private Presence _presence;

		private readonly ReadWriteQueue<IDirectedTextMessage> _directedMessages;

		private readonly ReadWriteQueue<IFailedDirectedTextMessage> _failedDirectedMessages;

		private readonly ReadWriteQueue<IAccountArchiveMessage> _accountArchive;

		private DateTime lastMessageTime;

		private DirectedMessageResult _directedMessageResult;

		private ArchiveQueryResult _accountArchiveResult;

		private ReadWriteHashSet<AccountId> _crossMutedCommunications;

		private readonly ReadWriteQueue<AccountId> _incomingSubscriptionRequests;

		private ParticipantPropertyUpdateFrequency _participantPropertyFrequency;

		private readonly ITextToSpeech _ttsSubSystem;

		[CompilerGenerated]
		private readonly AccountId <Key>k__BackingField;

		internal string AccountHandle
		{
			get
			{
				return null;
			}
		}

		public AccountId LoginSessionId
		{
			get
			{
				return null;
			}
		}

		public ITextToSpeech TTS
		{
			get
			{
				return null;
			}
		}

		public ParticipantPropertyUpdateFrequency ParticipantPropertyFrequency
		{
			get
			{
				return default(ParticipantPropertyUpdateFrequency);
			}
			set
			{
			}
		}

		public IReadOnlyDictionary<ChannelId, IChannelSession> ChannelSessions
		{
			get
			{
				return null;
			}
		}

		public ChannelId TransmittingChannel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AccountId Key
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public LoginState State
		{
			get
			{
				return default(LoginState);
			}
			private set
			{
			}
		}

		public bool IsInjectingAudio
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public IReadOnlyQueue<IDirectedTextMessage> DirectedMessages
		{
			get
			{
				return null;
			}
		}

		public IReadOnlyQueue<IFailedDirectedTextMessage> FailedDirectedMessages
		{
			get
			{
				return null;
			}
		}

		public IReadOnlyQueue<IAccountArchiveMessage> AccountArchive
		{
			get
			{
				return null;
			}
		}

		public IArchiveQueryResult AccountArchiveResult
		{
			get
			{
				return null;
			}
		}

		public IDirectedMessageResult DirectedMessageResult
		{
			get
			{
				return null;
			}
		}

		public Presence Presence
		{
			get
			{
				return default(Presence);
			}
			set
			{
			}
		}

		public IReadOnlyDictionary<AccountId, IPresenceSubscription> PresenceSubscriptions
		{
			get
			{
				return null;
			}
		}

		public IReadOnlyHashSet<AccountId> BlockedSubscriptions
		{
			get
			{
				return null;
			}
		}

		public IReadOnlyHashSet<AccountId> AllowedSubscriptions
		{
			get
			{
				return null;
			}
		}

		public IReadOnlyQueue<AccountId> IncomingSubscriptionRequests
		{
			get
			{
				return null;
			}
		}

		public IReadOnlyHashSet<AccountId> CrossMutedCommunications
		{
			get
			{
				return null;
			}
		}

		public TransmissionMode TransmissionType
		{
			get
			{
				return default(TransmissionMode);
			}
		}

		public ReadOnlyCollection<ChannelId> TransmittingChannels
		{
			get
			{
				return null;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged
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

		internal LoginSession(Client client, AccountId accountId)
		{
		}

		private void Instance_EventMessageReceived(vx_evt_base_t eventMessage)
		{
		}

		public void HandleMediaComplete(vx_evt_base_t eventMessage)
		{
		}

		private void HandleBuddyPresenceEvt(vx_evt_base_t eventMessage)
		{
		}

		private void HandleUserToUserMessage(vx_evt_base_t eventMessage)
		{
		}

		private void HandleAccountLoginStateChangeEvt(vx_evt_base_t eventMessage)
		{
		}

		private void HandleSubscription(vx_evt_base_t eventMessage)
		{
		}

		private void HandleAccountArchiveMessage(vx_evt_base_t eventMessage)
		{
		}

		private void HandleAccountArchiveQueryEnd(vx_evt_base_t eventMessage)
		{
		}

		private void HandleAccountSendMessageFailed(vx_evt_base_t eventMessage)
		{
		}

		public IAsyncResult BeginLogin(Uri server, string accessToken, SubscriptionMode subscriptionMode, IReadOnlyHashSet<AccountId> presenceSubscriptions, IReadOnlyHashSet<AccountId> blockedPresenceSubscriptions, IReadOnlyHashSet<AccountId> allowedPresenceSubscriptions, AsyncCallback callback)
		{
			return null;
		}

		public string GetLoginToken(string key, TimeSpan expiration)
		{
			return null;
		}

		private void Login(string accessToken, string connectorHandle, AsyncNoResult ar, [Optional] SubscriptionMode? mode)
		{
		}

		public void Logout()
		{
		}

		public IAsyncResult BeginLogin(Uri server, string accessToken, AsyncCallback callback)
		{
			return null;
		}

		public void EndLogin(IAsyncResult result)
		{
		}

		public IChannelSession GetChannelSession(ChannelId channelId)
		{
			return null;
		}

		public void DeleteChannelSession(ChannelId channelId)
		{
		}

		public void StartAudioInjection(string audioFilePath)
		{
		}

		public void StopAudioInjection()
		{
		}

		public IAsyncResult BeginAccountSetLoginProperties(ParticipantPropertyUpdateFrequency participantPropertyFrequency, AsyncCallback callback)
		{
			return null;
		}

		public void EndAccountSetLoginProperties(IAsyncResult result)
		{
		}

		public IAsyncResult BeginAddBlockedSubscription(AccountId userId, AsyncCallback callback)
		{
			return null;
		}

		public void EndAddBlockedSubscription(IAsyncResult result)
		{
		}

		public IAsyncResult BeginRemoveBlockedSubscription(AccountId userId, AsyncCallback callback)
		{
			return null;
		}

		public void EndRemoveBlockedSubscription(IAsyncResult result)
		{
		}

		public IAsyncResult BeginSendDirectedMessage(AccountId userId, string message, AsyncCallback callback)
		{
			return null;
		}

		public IAsyncResult BeginSendDirectedMessage(AccountId userId, string language, string message, string applicationStanzaNamespace, string applicationStanzaBody, AsyncCallback callback)
		{
			return null;
		}

		public void EndSendDirectedMessage(IAsyncResult result)
		{
		}

		public IAsyncResult BeginAccountArchiveQuery(DateTime? timeStart, DateTime? timeEnd, string searchText, AccountId userId, ChannelId channel, uint max, string afterId, string beforeId, int firstMessageIndex, AsyncCallback callback)
		{
			return null;
		}

		public void EndAccountArchiveQuery(IAsyncResult result)
		{
		}

		public IAsyncResult BeginAddAllowedSubscription(AccountId userId, AsyncCallback callback)
		{
			return null;
		}

		public void EndAddAllowedSubscription(IAsyncResult result)
		{
		}

		public IAsyncResult BeginRemoveAllowedSubscription(AccountId userId, AsyncCallback callback)
		{
			return null;
		}

		public void EndRemoveAllowedSubscription(IAsyncResult result)
		{
		}

		public IAsyncResult BeginAddPresenceSubscription(AccountId userId, AsyncCallback callback)
		{
			return null;
		}

		public IPresenceSubscription EndAddPresenceSubscription(IAsyncResult result)
		{
			return null;
		}

		public IAsyncResult BeginRemovePresenceSubscription(AccountId userId, AsyncCallback callback)
		{
			return null;
		}

		public void EndRemovePresenceSubscription(IAsyncResult result)
		{
		}

		public IAsyncResult SetCrossMutedCommunications(AccountId accountId, bool muted, AsyncCallback callback)
		{
			return null;
		}

		public IAsyncResult SetCrossMutedCommunications(List<AccountId> accountIdSet, bool muted, AsyncCallback callback)
		{
			return null;
		}

		public IAsyncResult ClearCrossMutedCommunications(AsyncCallback callback)
		{
			return null;
		}

		private void SendCrossMuteOperationRequest(vx_control_communications_operation controlOp, string userURIs, vx_mute_scope muteScope, [Optional] Action<vx_resp_account_control_communications_t> callback)
		{
		}

		private void SendCrossMuteOperationRequest(vx_control_communications_operation controlOp, List<AccountId> users, vx_mute_scope muteScope, [Optional] Action<vx_resp_account_control_communications_t> callback)
		{
		}

		private void WaitDeleteChannelSession(ChannelId channelId)
		{
		}

		private void CheckConnection(object source, ElapsedEventArgs e)
		{
		}

		private void AssertLoggedIn()
		{
		}

		private void AssertLoggedOut()
		{
		}

		internal void ClearTransmittingChannel(ChannelId channelId)
		{
		}

		private void Cleanup()
		{
		}

		public void SetTransmissionMode(TransmissionMode mode, [Optional] ChannelId singleChannel)
		{
		}

		public void SetTransmission()
		{
		}

		private void SetTransmitting(ChannelId channel)
		{
		}

		private void SetNoSessionTransmitting()
		{
		}

		private void SetAllSessionsTransmitting()
		{
		}
	}
}
