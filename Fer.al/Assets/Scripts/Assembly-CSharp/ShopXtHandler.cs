using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;
using WW.Debug;

[MessageRouteHandler]
public static class ShopXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestBuyItem>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<BuyItemResponse> <>t__builder;

		public string purchaseableDefId;

		public string shopDefId;

		public int inQuantity;

		private TaskAwaiter<BuyItemResponse> <>u__1;

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
	private struct <RequestShopList>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<ShopListResponse> <>t__builder;

		public string shopDefId;

		private TaskAwaiter<ShopListResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<RequestBuyItem>d__0))]
	[MessageSender(XtCmd.ShopBuyItem, false)]
	public static Task<BuyItemResponse> RequestBuyItem(string purchaseableDefId, string shopDefId, int inQuantity = 1)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestShopList>d__1))]
	[DebugButton("Request List", "Shop", true, false)]
	[MessageSender(XtCmd.ShopList, false)]
	public static Task<ShopListResponse> RequestShopList(string shopDefId)
	{
		return null;
	}
}
