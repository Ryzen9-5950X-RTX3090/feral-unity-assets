using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;
using WW.Debug;

[MessageRouteHandler]
public static class TradeXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestDebugTradeRequest>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		private TaskAwaiter <>u__1;

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
	private struct <AddItemRequest>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		private IEnumerator<Item> <>7__wrap1;

		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1;

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
	private struct <RemoveItemRequest>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		private IEnumerator<Item> <>7__wrap1;

		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1;

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
	private struct <RequestTradeRequest>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<TradeInitiateResponse> onSuccess;

		public Action<TradeFailResponse> onFailed;

		public string userToTradeWithId;

		private TaskAwaiter <>u__1;

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
	private struct <TradeAddRemoveItemRequest>d__7 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<TradeAddRemoveItemResponse> <>t__builder;

		public Item i;

		public bool isAdding;

		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1;

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
	private struct <TradeReadyRequest>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<TradeReadyResponse> <>t__builder;

		public bool inIsReady;

		private TaskAwaiter<TradeReadyResponse> <>u__1;

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
	private struct <TradeReadyAcceptRequest>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public Action<TradeReadyAcceptResponse> onSuccess;

		public Action<TradeFailResponse> onFailed;

		private TaskAwaiter <>u__1;

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
	private struct <TradeReadyRejectRequest>d__10 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<TradeReadyRejectResponse> <>t__builder;

		private TaskAwaiter<TradeReadyRejectResponse> <>u__1;

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
	private struct <TradeListRequest>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<TradeListResponse> <>t__builder;

		public string inUserUUID;

		private TaskAwaiter<TradeListResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<RequestDebugTradeRequest>d__0))]
	[DebugButton("Initiate Trade Request With elvir+trading2", "Trading", true, true)]
	public static Task RequestDebugTradeRequest()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<AddItemRequest>d__1))]
	[DebugButton("Add first item Request", "Trading", true, true)]
	public static Task AddItemRequest()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RemoveItemRequest>d__2))]
	[DebugButton("Remove first item Request", "Trading", true, true)]
	public static Task RemoveItemRequest()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestTradeRequest>d__3))]
	[MessageSender(XtCmd.TradeInitiate, false)]
	public static Task RequestTradeRequest(string userToTradeWithId, [Optional] Action<TradeInitiateResponse> onSuccess, [Optional] Action<TradeFailResponse> onFailed)
	{
		return null;
	}

	[MessageSender(XtCmd.TradeInitiateAccept, false)]
	public static void TradeRequestAcceptRequest()
	{
	}

	[MessageSender(XtCmd.TradeInitiateReject, false)]
	public static void TradeRequestRejectRequest()
	{
	}

	[MessageSender(XtCmd.TradeInitiateCancel, false)]
	public static void TradeRequestCancelRequest()
	{
	}

	[AsyncStateMachine(typeof(<TradeAddRemoveItemRequest>d__7))]
	[MessageSender(XtCmd.TradeAddRemoveItem, false)]
	public static Task<TradeAddRemoveItemResponse> TradeAddRemoveItemRequest(Item i, bool isAdding)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<TradeReadyRequest>d__8))]
	[MessageSender(XtCmd.TradeReady, false)]
	public static Task<TradeReadyResponse> TradeReadyRequest(bool inIsReady)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<TradeReadyAcceptRequest>d__9))]
	[MessageSender(XtCmd.TradeReadyAccept, false)]
	public static Task TradeReadyAcceptRequest([Optional] Action<TradeReadyAcceptResponse> onSuccess, [Optional] Action<TradeFailResponse> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<TradeReadyRejectRequest>d__10))]
	[MessageSender(XtCmd.TradeReadyReject, false)]
	public static Task<TradeReadyRejectResponse> TradeReadyRejectRequest()
	{
		return null;
	}

	[MessageSender(XtCmd.TradeExit, false)]
	public static void TradeExitRequest()
	{
	}

	[AsyncStateMachine(typeof(<TradeListRequest>d__12))]
	[MessageSender(XtCmd.TradeList, false)]
	[DebugButton("Request Trade List", "Trading", true, false)]
	public static Task<TradeListResponse> TradeListRequest(string inUserUUID)
	{
		return null;
	}

	[MessageSender(XtCmd.TradeListUpdate, false)]
	public static void TradeListUpdateRequest(string inItemInvID, bool inIsInTradeList)
	{
	}

	[MessageRoute(XtCmd.TradeInitiate, QueueMessageMode.Never)]
	private static void HandleTradeRequest(TradeInitiateResponse response)
	{
	}

	[MessageRoute(XtCmd.TradeInitiateFail, QueueMessageMode.Never)]
	private static void HandleTradeFailure(TradeFailResponse response)
	{
	}

	[MessageRoute(XtCmd.TradeInitiateAccept, QueueMessageMode.Never)]
	private static void HandleTradeAcceptRequest(TradeInitiateAcceptResponse response)
	{
	}

	[MessageRoute(XtCmd.TradeInitiateReject, QueueMessageMode.Never)]
	private static void HandleTradeRejectRequest(TradeInitiateRejectResponse response)
	{
	}

	[MessageRoute(XtCmd.TradeInitiateCancel, QueueMessageMode.Never)]
	private static void HandleTradeCancelRequest(TradeInitiateCancelResponse response)
	{
	}

	[MessageRoute(XtCmd.TradeAddRemoveItem, QueueMessageMode.Never)]
	private static void HandleTradeAddRemoveItemRequest(TradeAddRemoveItemResponse response)
	{
	}

	[MessageRoute(XtCmd.TradeReady, QueueMessageMode.Never)]
	private static void HandleTradeReadyRequest(TradeReadyResponse response)
	{
	}

	[MessageRoute(XtCmd.TradeReadyAccept, QueueMessageMode.Never)]
	private static void HandleTradeReadyAcceptRequest(TradeReadyAcceptResponse response)
	{
	}

	[MessageRoute(XtCmd.TradeReadyReject, QueueMessageMode.Never)]
	private static void HandleTradeReadyRejectRequest(TradeReadyRejectResponse response)
	{
	}

	[MessageRoute(XtCmd.TradeExit, QueueMessageMode.Never)]
	private static void HandleTradeExitRequest(TradeExitResponse response)
	{
	}

	[MessageRoute(XtCmd.TradeList, QueueMessageMode.Never)]
	private static void HandleTradeListRequest(TradeListResponse response)
	{
	}

	[MessageRoute(XtCmd.TradeListUpdate, QueueMessageMode.Never)]
	private static void HandleTradeListUpdateRequest(TradeListUpdateResponse response)
	{
	}
}
