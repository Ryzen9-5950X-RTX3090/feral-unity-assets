using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_IAPDetailItem : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public UI_IAPDetailItem <>4__this;

		public IAPItemReward inDetail;

		public CancellationToken inCancellationToken;

		private bool <hasImage>5__2;

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
	private WWImage _bulletPointImage;

	[SerializeField]
	private WWTextMeshProUGUI _descriptionText;

	public void Setup(string inLongDescription)
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__3))]
	public UniTask Setup(IAPItemReward inDetail, CancellationToken inCancellationToken)
	{
		return default(UniTask);
	}
}
