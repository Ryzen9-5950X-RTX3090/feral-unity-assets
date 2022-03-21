using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;
using UnityEngine;

public class LoginHelper : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Login>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder;

		public string username;

		public string password;

		private TaskAwaiter<LoginMessage> <>u__1;

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
	private struct <LoginWithToken>d__16 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder;

		public string username;

		public string longLiveToken;

		private TaskAwaiter<LoginMessage> <>u__1;

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
	private struct <LoginForNodeHop>d__17 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder;

		public string username;

		public string longLiveToken;

		private TaskAwaiter<LoginMessage> <>u__1;

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
	private struct <Login>d__19 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder;

		public string username;

		public string passwordOrToken;

		public LoginType loginType;

		public bool forNodeHop;

		private TaskAwaiter<LoginMessage> <>u__1;

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
	private struct <DoLogin>d__20 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<LoginMessage> <>t__builder;

		public LoginHelper <>4__this;

		public bool forNodeHop;

		private <>c__DisplayClass20_0 <>8__1;

		private ServerLoginResponse <loginResponse>5__2;

		private TaskAwaiter<WebLoginResponse> <>u__1;

		private TaskAwaiter<bool> <>u__2;

		private TaskAwaiter<ServerLoginResponse> <>u__3;

		private TaskAwaiter<InventoryListResponse> <>u__4;

		private int <timer>5__3;

		private int <delay>5__4;

		private TaskAwaiter <>u__5;

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
	private struct <LoginToWebServices>d__23 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WebLoginResponse> <>t__builder;

		public LoginHelper <>4__this;

		private WebLoginResponse <response>5__2;

		private TaskAwaiter<string> <>u__1;

		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__2;

		private FeralServerEnvironment <env>5__3;

		private TaskAwaiter<GetUserResponse> <>u__3;

		private TaskAwaiter<WWWResponse<GetBestGameServerResponse>> <>u__4;

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
	private struct <GetUserProfile>d__24 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<GetUserResponse> <>t__builder;

		public LoginType inLoginType;

		private TaskAwaiter<WWWResponse<GetUserResponse>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static LoginHelper instance;

	private string username;

	private string passwordOrToken;

	private LoginType loginType;

	public bool loginStartupItemRequestsComplete;

	private string _loginAuthTokenFromServer;

	private string _refreshToken;

	private string _uuid;

	private SystemLanguage _language;

	public LoginResult result
	{
		[CompilerGenerated]
		get
		{
			return default(LoginResult);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string AuthToken
	{
		get
		{
			return null;
		}
	}

	[AsyncStateMachine(typeof(<Login>d__15))]
	public static Task<LoginMessage> Login(string username, string password)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<LoginWithToken>d__16))]
	public static Task<LoginMessage> LoginWithToken(string username, string longLiveToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<LoginForNodeHop>d__17))]
	public static Task<LoginMessage> LoginForNodeHop(string username, string longLiveToken)
	{
		return null;
	}

	public static void LoginToDeveloperMode(string username, string password)
	{
	}

	[AsyncStateMachine(typeof(<Login>d__19))]
	private static Task<LoginMessage> Login(string username, string passwordOrToken, LoginType loginType, bool forNodeHop = false)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<DoLogin>d__20))]
	public Task<LoginMessage> DoLogin(bool forNodeHop = false)
	{
		return null;
	}

	public static void OnNormalLogin()
	{
	}

	public static string GetLoginStatusErrorMessage(LoginStatus inStatus)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<LoginToWebServices>d__23))]
	public Task<WebLoginResponse> LoginToWebServices()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<GetUserProfile>d__24))]
	public Task<GetUserResponse> GetUserProfile(LoginType inLoginType)
	{
		return null;
	}
}
