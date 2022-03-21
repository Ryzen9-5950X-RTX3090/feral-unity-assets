using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UniRx.Async;
using UnityEngine;

public class UI_Window_IAPLoadingWebApp : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public IAPItem inIAP;

		public UI_Window_IAPLoadingWebApp <>4__this;

		private UniTask.Awaiter <>u__1;

		private UniTask<WWWResponse<StorePageURLResponse>>.Awaiter <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private WWTextMeshProUGUI _headerText;

	public static void OpenWindow(IAPItem inIAP)
	{
	}

	public static void QueueWindow(IAPItem inIAP)
	{
	}

	public static void CloseWindow()
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__4))]
	private void Setup(IAPItem inIAP)
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
}
