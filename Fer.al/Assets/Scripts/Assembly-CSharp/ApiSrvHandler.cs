using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class ApiSrvHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestToken>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<APIRequestTokenResponse>> <>t__builder;

		private TaskAwaiter<WWWResponse<APIRequestTokenResponse>> <>u__1;

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
	private struct <RequestAuthenticate>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<APIClientAuthenticateResponse>> <>t__builder;

		public string clientId;

		public string answer;

		private TaskAwaiter<WWWResponse<APIClientAuthenticateResponse>> <>u__1;

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

	[AsyncStateMachine(typeof(<RequestToken>d__2))]
	public static Task<WWWResponse<APIRequestTokenResponse>> RequestToken()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestAuthenticate>d__3))]
	public static Task<WWWResponse<APIClientAuthenticateResponse>> RequestAuthenticate(string clientId, string answer)
	{
		return null;
	}
}
