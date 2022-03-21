using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;

public class TradeManager : SingletonManagerBase<TradeManager>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <InviteUserToTrade>d__5 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inTargetUserUUID;

		public TradeManager <>4__this;

		private UniTask<UserInfo>.Awaiter <>u__1;

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
	private struct <AddItemToTrade>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public Item inItem;

		public TradeManager <>4__this;

		public int inQuantity;

		private Item <clonedItem>5__2;

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
	private struct <RemoveItemFromTrade>d__10 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public Item inItem;

		public TradeManager <>4__this;

		private Item <itemToRemove>5__2;

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
	private struct <SetReadyState>d__11 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public TradeManager <>4__this;

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
	private struct <AcceptTrade>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public TradeManager <>4__this;

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
	private struct <RejectTrade>d__13 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public TradeManager <>4__this;

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
	private struct <OnTradeRequestInitiated>d__16 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public TradeInitiateResponse inMessage;

		public TradeManager <>4__this;

		private UniTask<UserInfo>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private Trade _currentTrade;

	public Trade CurrentTrade
	{
		get
		{
			return null;
		}
	}

	public override bool HasFinishCoroutine()
	{
		return default(bool);
	}

	public override IEnumerator FinishCoroutine()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<InviteUserToTrade>d__5))]
	public void InviteUserToTrade(string inTargetUserUUID)
	{
	}

	public void CancelTradeRequest()
	{
	}

	public void AcceptTradeRequest()
	{
	}

	public void RejectTradeRequest()
	{
	}

	[AsyncStateMachine(typeof(<AddItemToTrade>d__9))]
	public void AddItemToTrade(Item inItem, int inQuantity)
	{
	}

	[AsyncStateMachine(typeof(<RemoveItemFromTrade>d__10))]
	public void RemoveItemFromTrade(Item inItem)
	{
	}

	[AsyncStateMachine(typeof(<SetReadyState>d__11))]
	public void SetReadyState(bool inIsReady)
	{
	}

	[AsyncStateMachine(typeof(<AcceptTrade>d__12))]
	public void AcceptTrade()
	{
	}

	[AsyncStateMachine(typeof(<RejectTrade>d__13))]
	public void RejectTrade()
	{
	}

	public void ExitTrade()
	{
	}

	private void OnTradeFailed(TradeFailResponse inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnTradeRequestInitiated>d__16))]
	private void OnTradeRequestInitiated(TradeInitiateResponse inMessage)
	{
	}

	private void OnTradeRequestCancelled(TradeInitiateCancelResponse inMessage)
	{
	}

	private void OnTradeRequestRejected(TradeInitiateRejectResponse inMessage)
	{
	}

	private void OnTradeRequestAccepted(TradeInitiateAcceptResponse inMessage)
	{
	}

	private void OnTradeReady(TradeReadyResponse inMessage)
	{
	}

	private void OnTradeAddRemoveItem(TradeAddRemoveItemResponse inMessage)
	{
	}

	private void UnreadyUsers()
	{
	}

	private void OnTradeReadyAccept(TradeReadyAcceptResponse inMessage)
	{
	}

	private void OnTradeReadyReject(TradeReadyRejectResponse inMessage)
	{
	}

	private void OnTradeExited(TradeExitResponse inMessage)
	{
	}

	private void OnChatConversationJoined(ChatConversationCreateResponse inMessage)
	{
	}
}
