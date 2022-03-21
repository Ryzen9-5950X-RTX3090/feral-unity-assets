using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public class CreateAccountHelper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <CreateAccount>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<RegisterUserResponse>> <>t__builder;

		public Action<string> loadingTextCallback;

		public string displayName;

		public string emailAddress;

		public string password;

		public string emailVerificationCode;

		private TaskAwaiter<WWWResponse<RegisterUserResponse>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<CreateAccount>d__0))]
	public static Task<WWWResponse<RegisterUserResponse>> CreateAccount(string displayName, string emailAddress, string password, string emailVerificationCode, Action<string> loadingTextCallback)
	{
		return null;
	}
}
