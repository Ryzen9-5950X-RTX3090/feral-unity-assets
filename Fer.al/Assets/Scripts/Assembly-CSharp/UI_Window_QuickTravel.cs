using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class UI_Window_QuickTravel : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <BtnClicked_Sanctuary>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private TaskAwaiter<bool> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private GameObject _backBtn;

	private UI_WorldMapStage _stage;

	public static bool IsInstantiatedAndOpen
	{
		get
		{
			return default(bool);
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

	protected override void DoDelayedOpenAnimation()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void OnReceiveFocus()
	{
	}

	public override void OnLoseFocus()
	{
	}

	public override void MOnDestroy()
	{
	}

	[AsyncStateMachine(typeof(<BtnClicked_Sanctuary>d__14))]
	public void BtnClicked_Sanctuary()
	{
	}

	public void BtnClicked_Back()
	{
	}

	private void OnUIWorldMapStageLoaded(UIWorldMapStageLoadedMessage inMessage)
	{
	}
}
