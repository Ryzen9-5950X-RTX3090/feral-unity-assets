using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;
using UniRx.Async;
using UniRx.Async.CompilerServices;

[MessageRouteHandler]
public static class InventoryXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestItemsOfCategory>d__5 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<InventoryListResponse> <>t__builder;

		public ItemType category;

		private TaskAwaiter<InventoryListResponse> <>u__1;

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
	private struct <RequestItemsWithComponent>d__6<T> : IAsyncStateMachine where T : ItemComponent
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<InventoryListResponse> <>t__builder;

		private TaskAwaiter<InventoryListResponse> <>u__1;

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
	private struct <RequestItemById>d__7 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<InventoryListResponse> <>t__builder;

		public string itemId;

		private TaskAwaiter<InventoryListResponse> <>u__1;

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
	private struct <RequestInspirationCombine>d__10 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<InspirationCombineResponse> <>t__builder;

		public List<InspirationItemComponent> inInspirations;

		private TaskAwaiter<InspirationCombineResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static int MAX_ITEMS_TO_SEND_AT_ONCE;

	public static void AddItem(string defId)
	{
	}

	public static void AddEnigmaItem(string defId)
	{
	}

	[MessageSender(XtCmd.ItemAdd_DEBUG, false)]
	public static void RequestAddItem(BaseDef craftableDef, int amount = 1)
	{
	}

	[MessageSender(XtCmd.ItemAdd_ENIGMA, false)]
	public static void RequestAddEnigmaItem(BaseDef craftableDef, int amount = 1)
	{
	}

	[AsyncStateMachine(typeof(<RequestItemsOfCategory>d__5))]
	[MessageSender(XtCmd.ItemListOfTypeRequest, false)]
	public static Task<InventoryListResponse> RequestItemsOfCategory(ItemType category)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestItemsWithComponent>d__6<>))]
	[MessageSender(XtCmd.ItemListWithComponentRequest, false)]
	public static Task<InventoryListResponse> RequestItemsWithComponent<T>() where T : ItemComponent
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestItemById>d__7))]
	[MessageSender(XtCmd.ItemInfoRequest, false)]
	public static Task<InventoryListResponse> RequestItemById(string itemId)
	{
		return null;
	}

	[MessageSender(XtCmd.ItemUseDye, false)]
	public static void RequestDyeItem(string itemId, string[] dyeItemIds, int[] channelIndexes, int[] undyedChannelIndexes)
	{
	}

	[MessageSender(XtCmd.ItemUncraft, false)]
	public static void RequestUncraftItem(string itemId, int count)
	{
	}

	[AsyncStateMachine(typeof(<RequestInspirationCombine>d__10))]
	[MessageSender(XtCmd.ItemInspirationCombine, false)]
	public static UniTask<InspirationCombineResponse> RequestInspirationCombine(List<InspirationItemComponent> inInspirations)
	{
		return default(UniTask<InspirationCombineResponse>);
	}

	[MessageRoute(XtCmd.ItemListMoreResponse, QueueMessageMode.NotLoggedIn)]
	private static void HandleInventoryListMore(InventoryListMoreResponse res)
	{
	}

	[MessageRoute(XtCmd.ItemListResponse, QueueMessageMode.NotLoggedIn)]
	private static void HandleInventoryList(InventoryListResponse res)
	{
	}

	private static void ProcessInventoryListOrListMore(InventoryListResponse res)
	{
	}

	[MessageRoute(XtCmd.ItemListRemovedResponse, QueueMessageMode.NotLoggedIn)]
	private static void HandleInventoryListRemoved(InventoryListRemovedResponse res)
	{
	}
}
