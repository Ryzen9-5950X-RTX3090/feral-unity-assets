using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;

public class TobogganUI_Countdown : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Show>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public TobogganUI_Countdown <>4__this;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public CanvasGroup groupCount1;

	public CanvasGroup groupCount2;

	public CanvasGroup groupCount3;

	public CanvasGroup groupCountGO;

	[AsyncStateMachine(typeof(<Show>d__4))]
	public UniTask Show()
	{
		return default(UniTask);
	}
}
