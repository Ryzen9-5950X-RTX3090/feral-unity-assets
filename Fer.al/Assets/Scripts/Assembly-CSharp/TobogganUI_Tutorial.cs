using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;

public class TobogganUI_Tutorial : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <ShowTutorial>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public TobogganUI_Tutorial <>4__this;

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
	private CanvasGroup _canvasGroup;

	private bool _isShowing;

	[AsyncStateMachine(typeof(<ShowTutorial>d__2))]
	public UniTask ShowTutorial()
	{
		return default(UniTask);
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}
