using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class UI_Window_AstralShop : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SetupAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_AstralShop <>4__this;

		public CancellationToken inToken;

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
	private struct <OnItemBuy>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public BuyItemResponse inMessage;

		public UI_Window_AstralShop <>4__this;

		private TaskAwaiter<ShopListResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	[RootSelector("Astral Shop", "ShopChartData", false, false)]
	private string _shopDefId;

	[SerializeField]
	private UI_LazyItemList_AstralShop _itemList;

	private CancellationTokenSource _cancellationTokenSource;

	private bool _setupCompleted;

	public string ShopDefId
	{
		get
		{
			return null;
		}
	}

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup()
	{
	}

	[AsyncStateMachine(typeof(<SetupAsync>d__10))]
	private void SetupAsync(CancellationToken inToken)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void DoDelayedOpenAnimation()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	[AsyncStateMachine(typeof(<OnItemBuy>d__15))]
	private void OnItemBuy(BuyItemResponse inMessage)
	{
	}
}
