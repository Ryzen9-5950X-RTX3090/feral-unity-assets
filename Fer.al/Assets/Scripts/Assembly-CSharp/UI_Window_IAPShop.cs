using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;

public class UI_Window_IAPShop : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_IAPShop <>4__this;

		private UniTask.Awaiter <>u__1;

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
	private struct <DoDelayedOpenAnimation>d__10 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_IAPShop <>4__this;

		private UniTask.Awaiter <>u__1;

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
	private struct <SpawnShopItems>d__13 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public UI_Window_IAPShop <>4__this;

		private UniTask.Awaiter <>u__1;

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
	private struct <SpawnShopItem>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public UI_Window_IAPShop <>4__this;

		public IAPItem inIAPItem;

		public CancellationToken inCancellationToken;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private UI_IAPShopItem _shopItemPrefab;

	[SerializeField]
	private Transform _shopItemParent;

	[SerializeField]
	private GameObject _noItemsGroup;

	private List<UI_IAPShopItem> _shopItems;

	private CancellationTokenSource _cancellationTokenSource;

	private bool _setupCompleted;

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__9))]
	private void Setup()
	{
	}

	[AsyncStateMachine(typeof(<DoDelayedOpenAnimation>d__10))]
	protected override void DoDelayedOpenAnimation()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	[AsyncStateMachine(typeof(<SpawnShopItems>d__13))]
	private UniTask SpawnShopItems()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(<SpawnShopItem>d__14))]
	private UniTask SpawnShopItem(IAPItem inIAPItem, CancellationToken inCancellationToken)
	{
		return default(UniTask);
	}

	private void OnDetailWindowOpened(WindowOpenedMessage inMessage)
	{
	}

	private void OnDetailWindowClosed(WindowClosedMessage inMessage)
	{
	}
}
