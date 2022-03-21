using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public class SecurityController
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <requestAuthTokenAndJWT>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<string> <>t__builder;

		private TaskAwaiter<WWWResponse<APIRequestTokenResponse>> <>u__1;

		private TaskAwaiter<WWWResponse<APIClientAuthenticateResponse>> <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private static string _salt;

	[AsyncStateMachine(typeof(<requestAuthTokenAndJWT>d__1))]
	public static Task<string> requestAuthTokenAndJWT()
	{
		return null;
	}

	public static string encryptChallenge(string challenge, string IV)
	{
		return null;
	}

	private static string generateSharedSecret()
	{
		return null;
	}
}
