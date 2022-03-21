using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Events;
using WW.Debug;

public class GiftManager : SingletonManagerBase<GiftManager>
{
	private class GiftDisplayQueue
	{
		private GiftInfo _giftInfo;

		private int _currentGiftIndex;

		public GiftDisplayQueue(GiftInfo giftInfo)
		{
		}

		private void Clear()
		{
		}

		private void ShowNextGift()
		{
		}
	}

	public class GiftInfo
	{
		public readonly int numGifts;

		public readonly string[] itemIds;

		public readonly int[] itemCounts;

		public readonly GiftFromType fromType;

		public GiftInfo(int numGifts, string[] itemIds, int[] itemCounts)
		{
		}

		public GiftInfo(GiftPushMessage inMessage)
		{
		}

		public GiftInfo(string inItemId, int inCount = 0)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnRoomJoinSuccess>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public GiftManager <>4__this;

		private TaskAwaiter<WindowOpenCompleteMessage> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private bool _firstRoomJoin;

	[DebugField("Gift Deferment Requests", "GiftManager", true, false)]
	private int _deferGiftRequests;

	private List<GiftInfo> _deferedGifts;

	private bool DeferGifts
	{
		get
		{
			return default(bool);
		}
	}

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	public void RequestGiftDeferment(bool inDefer)
	{
	}

	[AsyncStateMachine(typeof(<OnRoomJoinSuccess>d__8))]
	private void OnRoomJoinSuccess(RoomJoinSuccessMessage inMessage)
	{
	}

	private void OnGiftPush(GiftPushMessage inMessage)
	{
	}

	private void OnGiftDefermentEnded()
	{
	}

	public void ShowAndRedeem(GiftInfo inGiftInfo)
	{
	}

	private static void OpenItemUI(GiftItemComponent inGift, [Optional] UnityAction<UI_Window> inOnWindowClosed, [Optional] Action inExtraButtonCallback, [Optional] string inExtraButtonText)
	{
	}
}
