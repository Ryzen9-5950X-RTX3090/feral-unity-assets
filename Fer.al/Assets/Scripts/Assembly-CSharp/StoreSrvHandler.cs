using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using WW.Debug;

public class StoreSrvHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestIAPs>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<ListIAPsResponse> <>t__builder;

		private TaskAwaiter<WWWResponse> <>u__1;

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
	private struct <DEBUG_RequestIAPs>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private UniTask<ListIAPsResponse>.Awaiter <>u__1;

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

	[AsyncStateMachine(typeof(<RequestIAPs>d__2))]
	public static UniTask<ListIAPsResponse> RequestIAPs()
	{
		return default(UniTask<ListIAPsResponse>);
	}

	[AsyncStateMachine(typeof(<DEBUG_RequestIAPs>d__3))]
	[DebugButton("Get IAPs", "Store Service", true, false)]
	public static void DEBUG_RequestIAPs()
	{
	}

	private static string GetStorePlatformString()
	{
		return null;
	}
}
