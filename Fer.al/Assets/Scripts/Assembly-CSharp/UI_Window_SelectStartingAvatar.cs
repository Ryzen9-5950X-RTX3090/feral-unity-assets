using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;

public class UI_Window_SelectStartingAvatar : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <DoAvatarSelection>d__10 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private <>c__DisplayClass10_0 <>8__1;

		public int inAvatarIndex;

		public UI_Window_SelectStartingAvatar <>4__this;

		private UniTask.Awaiter <>u__1;

		private TaskAwaiter<WindowOpenCompleteMessage> <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
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

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_Quit()
	{
	}

	public void BtnClicked_Kitsune()
	{
	}

	public void BtnClicked_Senri()
	{
	}

	[AsyncStateMachine(typeof(<DoAvatarSelection>d__10))]
	private void DoAvatarSelection(int inAvatarIndex)
	{
	}
}
