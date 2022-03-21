using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;
using UniRx.Async;

[MessageRouteHandler]
public static class SanctuaryXtHandler
{
	public class DenStateUpdateResponse : ServerMessage
	{
		public readonly bool status;

		public readonly string[] AddedItemIds;

		public readonly string[] RemovedItemIds;

		public DenStateUpdateResponse(INetMessageReader data)
		{
		}
	}

	[RoutedMessage(XtCmd.SanctuaryUpgradeStart, QueueMessageMode.Never)]
	public class HandleSanctuaryUpgradeStart : ServerMessage
	{
		public readonly bool status;

		public HandleSanctuaryUpgradeStart(INetMessageReader data)
		{
		}
	}

	[RoutedMessage(XtCmd.SanctuaryUpgradeComplete, QueueMessageMode.Never)]
	public class HandleSanctuaryUpgradeComplete : ServerMessage
	{
		public readonly bool status;

		public HandleSanctuaryUpgradeComplete(INetMessageReader data)
		{
		}
	}

	[RoutedMessage(XtCmd.SanctuaryPurchase, QueueMessageMode.Never)]
	public class SanctuaryPurchaseResponse : ServerMessage
	{
		public readonly bool Success;

		public SanctuaryPurchaseResponse(INetMessageReader data)
		{
		}
	}

	[RoutedMessage(XtCmd.SanctuarySwitch, QueueMessageMode.Never)]
	public class SanctuarySwitchResponse : ServerMessage
	{
		public readonly bool Success;

		public SanctuarySwitchResponse(INetMessageReader data)
		{
		}
	}

	[RoutedMessage(XtCmd.SanctuaryLookSave, QueueMessageMode.Never)]
	public class SanctuaryLookSaveResponse : ServerMessage
	{
		public readonly string ItemId;

		public bool Success
		{
			get
			{
				return default(bool);
			}
		}

		public SanctuaryLookSaveResponse(INetMessageReader data)
		{
		}
	}

	[RoutedMessage(XtCmd.SanctuaryLookLoad, QueueMessageMode.Never)]
	public class SanctuaryLookLoadResponse : ServerMessage
	{
		public readonly string ItemId;

		public bool Success
		{
			get
			{
				return default(bool);
			}
		}

		public SanctuaryLookLoadResponse(INetMessageReader data)
		{
		}
	}

	[MessageRouteHandler]
	private static class DefaultHandlers
	{
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestJoinMySanctuary>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<bool> <>t__builder;

		private TaskAwaiter<bool> <>u__1;

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
	private struct <GoToSanctuary>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<bool> <>t__builder;

		public string uuid;

		private <>c__DisplayClass2_0 <>8__1;

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
	private struct <RequestJoinSanctuary>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public string ownerUUIDStr;

		public Action<RoomJoinSuccessMessage> onSuccess;

		public Action<RoomJoinFailedMessage> onFailed;

		private <>c__DisplayClass3_0 <>8__1;

		private TaskAwaiter<bool> <>u__1;

		private TaskAwaiter <>u__2;

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
	private struct <RequestUpdateDenState>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public UpdateItem[] itemsToUpdate;

		public RemoveItem[] itemsToRemove;

		public List<RoomData> roomData;

		private TaskAwaiter<DenStateUpdateResponse> <>u__1;

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
	private struct <RequestSanctuaryPurchase>d__7 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<SanctuaryPurchaseResponse> <>t__builder;

		public string purchaseableDefId;

		private TaskAwaiter<SanctuaryPurchaseResponse> <>u__1;

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
	private struct <RequestSanctuarySwitch>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<SanctuarySwitchResponse> <>t__builder;

		public string lookId;

		private TaskAwaiter<SanctuarySwitchResponse> <>u__1;

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
	private struct <RequestSanctuaryLookSave>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<SanctuaryLookSaveResponse> <>t__builder;

		public SanctuaryLookItemComponent inLook;

		private TaskAwaiter<SanctuaryLookSaveResponse> <>u__1;

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
	private struct <RequestSanctuaryLookLoad>d__10 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<SanctuaryLookLoadResponse> <>t__builder;

		public string lookId;

		private TaskAwaiter<SanctuaryLookLoadResponse> <>u__1;

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
	private struct <<RequestJoinSanctuary>g__handleEitherMessage|3_2>d : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public RoomJoinSuccessMessage inSuccessMessage;

		public RoomJoinFailedMessage inFailMessage;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static string sanctuaryJoinOwnerUUID;

	[AsyncStateMachine(typeof(<RequestJoinMySanctuary>d__1))]
	public static Task<bool> RequestJoinMySanctuary()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<GoToSanctuary>d__2))]
	public static Task<bool> GoToSanctuary(string uuid)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestJoinSanctuary>d__3))]
	[MessageSender(XtCmd.SanctuaryJoin, false)]
	public static Task RequestJoinSanctuary(string ownerUUIDStr, [Optional] Action<RoomJoinSuccessMessage> onSuccess, [Optional] Action<RoomJoinFailedMessage> onFailed)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestUpdateDenState>d__4))]
	[MessageSender(XtCmd.SanctuaryStateUpdate, false)]
	public static Task RequestUpdateDenState(UpdateItem[] itemsToUpdate, RemoveItem[] itemsToRemove, List<RoomData> roomData)
	{
		return null;
	}

	public static void RequestSanctuaryUpgradeStart(int stage, int[] enlargedAreaIndexes, [Optional] Action<SanctuaryUpgradeStartSuccessMessage> onSuccess, [Optional] Action<SanctuaryUpgradeStartFailedMessage> onFailed)
	{
	}

	public static void RequestSanctuaryUpgradeComplete(string twiggleId, [Optional] Action<SanctuaryUpgradeCompleteSuccessMessage> onSuccess, [Optional] Action<SanctuaryUpgradeCompleteFailedMessage> onFailed)
	{
	}

	[AsyncStateMachine(typeof(<RequestSanctuaryPurchase>d__7))]
	public static Task<SanctuaryPurchaseResponse> RequestSanctuaryPurchase(string purchaseableDefId)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestSanctuarySwitch>d__8))]
	public static Task<SanctuarySwitchResponse> RequestSanctuarySwitch(string lookId)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestSanctuaryLookSave>d__9))]
	public static Task<SanctuaryLookSaveResponse> RequestSanctuaryLookSave(SanctuaryLookItemComponent inLook)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestSanctuaryLookLoad>d__10))]
	public static Task<SanctuaryLookLoadResponse> RequestSanctuaryLookLoad(string lookId)
	{
		return null;
	}

	[MessageRoute(XtCmd.SanctuaryStateUpdate, QueueMessageMode.Never)]
	private static void HandleSanctuaryStateUpdateRequest(DenStateUpdateResponse response)
	{
	}
}
