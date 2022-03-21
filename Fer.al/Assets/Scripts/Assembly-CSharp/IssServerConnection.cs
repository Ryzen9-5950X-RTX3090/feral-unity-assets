using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Iss;
using LitJson;
using Server;

public class IssServerConnection : ServerConnection
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Connect>d__13 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<bool> <>t__builder;

		public IssServerConnection <>4__this;

		private DateTime <timeoutTime>5__2;

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
	private struct <DisconnectAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public IssServerConnection <>4__this;

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
	private struct <Login>d__16 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<ServerLoginResponse> <>t__builder;

		public IssServerConnection <>4__this;

		public string uuid;

		public int sessionId;

		public string authToken;

		private <>c__DisplayClass16_0 <>8__1;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public const int DEFAULT_ROOM_ID = 1;

	public const string ZONE_SBI_LOGIN = "sbiLogin";

	public const string ZONE_SBI_ACCOUNT = "sbiAccountZone";

	public const string XT_NAME_ONE_XT_TO_RULE_THEM_ALL = "o";

	public const string XT_NAME_ACCOUNT = "a";

	private IssClient _iss;

	private string _host;

	private int _port;

	private string _hashKey;

	private LoginMode _loginMode;

	private string _xtName;

	public override void Init(FeralServerEnvironment environment)
	{
	}

	~IssServerConnection()
	{
	}

	[AsyncStateMachine(typeof(<Connect>d__13))]
	public override Task<bool> Connect(string address)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<DisconnectAsync>d__14))]
	public override Task DisconnectAsync()
	{
		return null;
	}

	public void GetKey()
	{
	}

	[AsyncStateMachine(typeof(<Login>d__16))]
	public override Task<ServerLoginResponse> Login(string uuid, string authToken, int sessionId)
	{
		return null;
	}

	public override void Logout()
	{
	}

	public override void Switching()
	{
	}

	public override void ProcessEventQueue()
	{
	}

	public override void Send(INetMessageWriter data)
	{
	}

	private void OnConnection(bool success, string error)
	{
	}

	private void OnConnectionLost()
	{
	}

	private void OnRandomKey(string key)
	{
	}

	private void OnXtMessage(object inData, IssClient.XtMsgType inType)
	{
	}

	private void ProcessLoginData(JsonData json)
	{
	}

	private void OnLogin(bool success, string name, string failureMsg)
	{
	}

	private void OnLogout()
	{
	}

	private void OnDebugMessage(string message)
	{
	}

	private void Log(string message)
	{
	}

	private void LogWarning(string message)
	{
	}

	private void LogError(string message)
	{
	}
}
