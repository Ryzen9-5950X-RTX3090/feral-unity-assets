using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_IAPShopItem : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__7 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public UI_IAPShopItem <>4__this;

		public IAPItem inItem;

		public CancellationToken inCancellationToken;

		private TaskAwaiter<Sprite> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private FeralButton _moreInfoBtn;

	[SerializeField]
	[Header("Loading")]
	private CanvasGroup _loadingGroup;

	[SerializeField]
	private CanvasGroup _loadedGroup;

	[SerializeField]
	[Header("Content")]
	private WWImage _iapImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private WWTextMeshProUGUI _descriptionText;

	private IAPItem _iapItem;

	[AsyncStateMachine(typeof(<Setup>d__7))]
	public UniTask Setup(IAPItem inItem, CancellationToken inCancellationToken)
	{
		return default(UniTask);
	}

	public void BtnClicked_MoreInfo()
	{
	}
}
