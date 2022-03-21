using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_IAPDetails : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_IAPDetails <>4__this;

		public IAPItem inIAPItem;

		private TaskAwaiter<Sprite> <>u__1;

		private UniTask.Awaiter <>u__2;

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
	private struct <DoDelayedOpenAnimation>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_IAPDetails <>4__this;

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
	private struct <SpawnDetailItems>d__16 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public UI_Window_IAPDetails <>4__this;

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
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private WWTextMeshProUGUI _descriptionText;

	[SerializeField]
	private WWTextMeshProUGUI _priceText;

	[SerializeField]
	private WWImage _iapImage;

	[SerializeField]
	private FeralButton _infoBtn;

	[SerializeField]
	private Transform _descriptionParent;

	[SerializeField]
	private UI_IAPDetailItem _detailItemPrefab;

	private IAPItem _iapItem;

	private List<UI_IAPDetailItem> _detailItems;

	private CancellationTokenSource _cancellationTokenSource;

	private bool _setupCompleted;

	public static void OpenWindow(IAPItem inIAPItem)
	{
	}

	public static void QueueWindow(IAPItem inIAPItem)
	{
	}

	public static void CloseWindow()
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__14))]
	public void Setup(IAPItem inIAPItem)
	{
	}

	[AsyncStateMachine(typeof(<DoDelayedOpenAnimation>d__15))]
	protected override void DoDelayedOpenAnimation()
	{
	}

	[AsyncStateMachine(typeof(<SpawnDetailItems>d__16))]
	private UniTask SpawnDetailItems(CancellationToken inCancellationToken)
	{
		return default(UniTask);
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnMultiItemPopupOpened(WindowOpenedMessage inMessage)
	{
	}

	private void OnMultiItemPopupClosed(WindowClosedMessage inMessage)
	{
	}

	public void BtnClicked_BundleContents()
	{
	}

	public void BtnClicked_Purchase()
	{
	}
}
