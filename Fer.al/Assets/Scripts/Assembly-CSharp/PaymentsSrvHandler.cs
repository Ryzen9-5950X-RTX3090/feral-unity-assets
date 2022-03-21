using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;

public class PaymentsSrvHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestStorePageURL>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<WWWResponse<StorePageURLResponse>> <>t__builder;

		public string inIAPItemId;

		private TaskAwaiter<WWWResponse<StorePageURLResponse>> <>u__1;

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

	[AsyncStateMachine(typeof(<RequestStorePageURL>d__2))]
	public static UniTask<WWWResponse<StorePageURLResponse>> RequestStorePageURL(string inIAPItemId)
	{
		return default(UniTask<WWWResponse<StorePageURLResponse>>);
	}
}
