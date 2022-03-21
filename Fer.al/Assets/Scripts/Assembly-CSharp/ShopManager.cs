using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WW.Debug;

public class ShopManager
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <GetNewestItemStartTimeInShop>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<DateTime?> <>t__builder;

		public string inShopDefId;

		private TaskAwaiter<ShopListResponse> <>u__1;

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
	private struct <RequestServerBuyItem>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inPurchasableDefId;

		public string inShopDefId;

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

	public ContentVisitRecord AstralShopWindowVisitRecord;

	private static ShopManager _instance;

	public static ShopManager Instance
	{
		get
		{
			return null;
		}
	}

	[AsyncStateMachine(typeof(<GetNewestItemStartTimeInShop>d__1))]
	public Task<DateTime?> GetNewestItemStartTimeInShop(string inShopDefId)
	{
		return null;
	}

	static ShopManager()
	{
	}

	private ShopManager()
	{
	}

	[DebugButton("Buy/Craft", "Shop", true, false)]
	public static void BuyItem_DEBUG(string defId, string shopDefId)
	{
	}

	public static void BuyItem(BaseDef inPurchasableDef, string inShopDefId, int inQuantity = 1)
	{
	}

	public static void BuyItem(PurchaseableDefComponent inPurchasableDef, ShopContentDefComponent inShopDef, int inQuantity = 1)
	{
	}

	public static void BuyItem(string inPurchasableDefId, ShopContentDefComponent inShopDef, int inQuantity = 1)
	{
	}

	public static void BuyItem(PurchaseableDefComponent inPurchasableDef, string inShopDefId, int inQuantity = 1)
	{
	}

	public static void BuyItem(string inPurchasableDefId, string inShopDefId, int inQuantity = 1)
	{
	}

	[IteratorStateMachine(typeof(<_BuyItem>d__13))]
	private IEnumerator _BuyItem(string inPurchasableDefId, string inShopDefId, int inQuantity = 1)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestServerBuyItem>d__14))]
	private void RequestServerBuyItem(string inPurchasableDefId, string inShopDefId, int inQuantity = 1)
	{
	}
}
