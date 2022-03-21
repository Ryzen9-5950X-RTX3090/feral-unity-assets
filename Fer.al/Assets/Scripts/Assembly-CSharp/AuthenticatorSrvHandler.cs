using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class AuthenticatorSrvHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Authenticate>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<AuthenticateResponse>> <>t__builder;

		public string username;

		public string password;

		public string clientAuth;

		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__1;

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
	private struct <AuthenticateWithToken>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<AuthenticateResponse>> <>t__builder;

		public string authToken;

		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__1;

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
	private struct <ResetPassword>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<PasswordResetResponse>> <>t__builder;

		public string email;

		public string clientAuth;

		private TaskAwaiter<WWWResponse<PasswordResetResponse>> <>u__1;

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
	private struct <GetAuthToken>d__5 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<AuthenticateResponse>> <>t__builder;

		public string refreshToken;

		private TaskAwaiter<WWWResponse<AuthenticateResponse>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static string Host
	{
		get
		{
			return null;
		}
	}

	[AsyncStateMachine(typeof(<Authenticate>d__2))]
	public static Task<WWWResponse<AuthenticateResponse>> Authenticate(string username, string password, string clientAuth)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<AuthenticateWithToken>d__3))]
	public static Task<WWWResponse<AuthenticateResponse>> AuthenticateWithToken(string authToken)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<ResetPassword>d__4))]
	public static Task<WWWResponse<PasswordResetResponse>> ResetPassword(string email, string clientAuth)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<GetAuthToken>d__5))]
	public static Task<WWWResponse<AuthenticateResponse>> GetAuthToken(string refreshToken)
	{
		return null;
	}
}
