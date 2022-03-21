using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;

public static class DecreeSrvHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestDecrees>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<ListDecreesResponse> <>t__builder;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<RequestDecrees>d__0))]
	public static UniTask<ListDecreesResponse> RequestDecrees()
	{
		return default(UniTask<ListDecreesResponse>);
	}
}
