using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;
using UnityEngine;

[MessageRouteHandler]
public class NetworkManager : SingletonManagerBase<NetworkManager>
{
	public enum AutoLoginState
	{
		NoAutoLogin,
		DoAutoLogin,
		NodeHopAutoLogin
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <InitFakeServer>d__101 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		private TaskAwaiter <>u__1;

		private TaskAwaiter<LoginMessage> <>u__2;

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
	private struct <Disconnect>d__104 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public DisconnectReason reason;

		private TaskAwaiter <>u__1;

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
	private struct <DisconnectAsync>d__105 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public DisconnectReason reason;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public const string WebRegion = "US";

	public bool LogMovementCommands;

	[SerializeField]
	private List<string> _ignoreLoggingXtCmds;

	[SerializeField]
	private ServerDeployState _serverDeployState;

	public static AutoLoginState AutoLogin;

	public static readonly DateTimeOffset ServerEpoch;

	public static string autoLoginDisplayName;

	public static string autoLoginEmailUsername;

	public static string autoLoginPassword;

	public static string autoLoginAuthToken;

	public static string autoLoginRefreshToken;

	public static string autoLoginEnhancedCustomization;

	public static int nodeHopSessionId;

	public static string nodeHopNewHost;

	public static string nodeHopUUID;

	private string _jwt;

	private string _uuid;

	private ServerConnection _serverConnection;

	private ChatServiceConnection _chatServiceConnection;

	private VoiceChatServiceConnection _voiceChatServiceConnection;

	private MessageRouter _router;

	private FeralServerEnvironment _serverEnvironment;

	private DateTimeOffset _serverTimeAtLogin;

	private float _clientTmeAtLogin;

	public static ServerConnection ServerConnection
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static bool IsConnected
	{
		get
		{
			return default(bool);
		}
	}

	public static bool IsLoggedIn
	{
		get
		{
			return default(bool);
		}
	}

	public static bool IsFakeServer
	{
		get
		{
			return default(bool);
		}
	}

	public static ChatServiceConnection ChatServiceConnection
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static VoiceChatServiceConnection VoiceChatServiceConnection
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static bool IsDev
	{
		get
		{
			return default(bool);
		}
	}

	public static bool IsStage
	{
		get
		{
			return default(bool);
		}
	}

	public static bool IsProd
	{
		get
		{
			return default(bool);
		}
	}

	public static string AutoLoginRoomName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static string AutoLoginBuddyName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public DateTime LastMaintenanceMode
	{
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static DisconnectReason DisconnectReason
	{
		[CompilerGenerated]
		get
		{
			return default(DisconnectReason);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static int UserID
	{
		get
		{
			return default(int);
		}
	}

	public static string Username
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

	public static int RoomID
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static string RoomDefID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static MessageRouter Router
	{
		get
		{
			return null;
		}
	}

	public static FeralServerEnvironment Environment
	{
		get
		{
			return null;
		}
	}

	public static ServerDeployState DeployState
	{
		get
		{
			return default(ServerDeployState);
		}
		set
		{
		}
	}

	private static DateTimeOffset ServerTimeAtLogin
	{
		get
		{
			return default(DateTimeOffset);
		}
	}

	private static float ClientTimeAtLogin
	{
		get
		{
			return default(float);
		}
	}

	public static DateTimeOffset ServerTime
	{
		get
		{
			return default(DateTimeOffset);
		}
	}

	public static string JWT
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string UUID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool InternetIsReachable
	{
		get
		{
			return default(bool);
		}
	}

	public static bool ShouldIgnoreLogginForXtCommand(string xtCmd)
	{
		return default(bool);
	}

	public override void Init()
	{
	}

	private void InstantiateServices()
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MUpdate()
	{
	}

	public void External_OnApplicationPause(bool inPaused)
	{
	}

	public void OnApplicationPause(bool inPaused)
	{
	}

	private void FocusChange(bool inPaused)
	{
	}

	[AsyncStateMachine(typeof(<InitFakeServer>d__101))]
	public static Task InitFakeServer()
	{
		return null;
	}

	public static void InitializeConnections()
	{
	}

	public static void ConnectConnections()
	{
	}

	[AsyncStateMachine(typeof(<Disconnect>d__104))]
	public static void Disconnect(DisconnectReason reason)
	{
	}

	[AsyncStateMachine(typeof(<DisconnectAsync>d__105))]
	public static Task DisconnectAsync(DisconnectReason reason)
	{
		return null;
	}

	public static void Logout(bool clearToken = false)
	{
	}

	public static void SwitchServer(string newHost)
	{
	}

	public static INetMessageWriter CreateOutgoingMessage(XtCmd cmd)
	{
		return null;
	}

	public static void SendServerMessage(XtCmd cmd)
	{
	}

	public static void SendServerMessage(INetMessageWriter message)
	{
	}

	public static void SendChatServiceRequest(PersistentServiceRequest req)
	{
	}

	public static void SendVoiceChatServiceRequest(PersistentServiceRequest req)
	{
	}

	private void OnServerConnectionLost(ServerConnectionLostMessage m)
	{
	}

	[IteratorStateMachine(typeof(<ServerConnectionLostLogic>d__114))]
	private IEnumerator ServerConnectionLostLogic()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<WakeupConnection>d__117))]
	public static IEnumerator WakeupConnection()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<CanReachInternet>d__118))]
	public static IEnumerator CanReachInternet(Action<bool> callback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<CanPhoneHome>d__119))]
	public static IEnumerator CanPhoneHome(Action<bool> callback, bool socketCheck = true)
	{
		return null;
	}

	public static string EncryptPassword(string inPassword, bool encrypt)
	{
		return null;
	}

	public static string HashDeveloperPassword(string inPassword, bool hash)
	{
		return null;
	}

	public void SetEnvironment(FeralServerEnvironment env)
	{
	}

	public static string GetIPAddress()
	{
		return null;
	}

	public static void ClearSavedToken()
	{
	}

	public static void ClearSavedLoginInfo()
	{
	}

	public void SetLoginTime(long inServerTime)
	{
	}

	private static bool CheckDeviceConnection(Action<bool> callback)
	{
		return default(bool);
	}
}
