using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class AvatarXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestAvatarLookGet>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<AvatarLookGetResponse> <>t__builder;

		public string requestedUUID;

		private TaskAwaiter<AvatarLookGetResponse> <>u__1;

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
	private struct <RequestAvatarLookSwitch>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<AvatarLookSwitchResponse> <>t__builder;

		public string itemId;

		private TaskAwaiter<AvatarLookSwitchResponse> <>u__1;

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
	private struct <RequestAvatarLookCustomize>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<AvatarLookCustomizeResponse> <>t__builder;

		public AvatarLookItemComponent inLook;

		private TaskAwaiter<AvatarLookCustomizeResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<RequestAvatarLookGet>d__0))]
	[MessageSender(XtCmd.AvatarLookGet, false)]
	public static Task<AvatarLookGetResponse> RequestAvatarLookGet(string requestedUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestAvatarLookSwitch>d__1))]
	[MessageSender(XtCmd.AvatarLookSwitch, false)]
	public static Task<AvatarLookSwitchResponse> RequestAvatarLookSwitch(string itemId)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestAvatarLookCustomize>d__2))]
	[MessageSender(XtCmd.AvatarLookCustomize, false)]
	public static Task<AvatarLookCustomizeResponse> RequestAvatarLookCustomize(AvatarLookItemComponent inLook)
	{
		return null;
	}

	[MessageSender(XtCmd.AvatarAction, false)]
	public static void RequestAvatarAction(AvatarActionDefComponent inAction)
	{
	}

	[MessageRoute(XtCmd.AvatarLookSwitch, QueueMessageMode.Never)]
	private static void HandleAvatarLookSwitch(AvatarLookSwitchResponse response)
	{
	}
}
