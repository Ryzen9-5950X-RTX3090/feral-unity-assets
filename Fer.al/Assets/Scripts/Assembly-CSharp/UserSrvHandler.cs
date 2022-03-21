using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class UserSrvHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Register>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<RegisterUserResponse>> <>t__builder;

		public RegisterAccountInfo info;

		public string clientAuth;

		private TaskAwaiter<WWWResponse<RegisterUserResponse>> <>u__1;

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
	private struct <GetUserProfile>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<GetUserResponse>> <>t__builder;

		private TaskAwaiter<WWWResponse<GetUserResponse>> <>u__1;

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
	private struct <SetPrivacySettings>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<UserProfilePrivacyResponse>> <>t__builder;

		public UserProfilePrivacyResponse info;

		private TaskAwaiter<WWWResponse<UserProfilePrivacyResponse>> <>u__1;

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

	[AsyncStateMachine(typeof(<Register>d__2))]
	public static Task<WWWResponse<RegisterUserResponse>> Register(RegisterAccountInfo info, string clientAuth)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<GetUserProfile>d__3))]
	public static Task<WWWResponse<GetUserResponse>> GetUserProfile()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<SetPrivacySettings>d__4))]
	public static Task<WWWResponse<UserProfilePrivacyResponse>> SetPrivacySettings(UserProfilePrivacyResponse info)
	{
		return null;
	}
}
