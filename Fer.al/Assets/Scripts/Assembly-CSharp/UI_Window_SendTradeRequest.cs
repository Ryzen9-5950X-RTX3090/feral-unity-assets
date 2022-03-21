using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using WW.Debug;

public class UI_Window_SendTradeRequest : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inTargetUUID;

		public UI_Window_SendTradeRequest <>4__this;

		private UniTask<UserInfo>.Awaiter <>u__1;

		private TaskAwaiter<TradeListResponse> <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private UI_LazyItemList_ReadonlyItemList _itemList;

	[SerializeField]
	private GameObject _groupNoItems;

	[SerializeField]
	private WWTextMeshProUGUI _noItemsText;

	private UserInfo _targetUser;

	[DebugButton("Open Trade Request", "Trading", true, true)]
	public static void OpenWindow(string inTargetUUID)
	{
	}

	public static void QueueWindow(string inTargetUUID)
	{
	}

	public static void CloseWindow()
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__8))]
	public void Setup(string inTargetUUID)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_InviteToTrade()
	{
	}

	private void OnTradeStarted(TradeStartedMessage inMessage)
	{
	}
}
