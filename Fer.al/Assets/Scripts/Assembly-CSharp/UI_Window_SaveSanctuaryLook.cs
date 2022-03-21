using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;

public class UI_Window_SaveSanctuaryLook : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SaveLook>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public SanctuaryLookItemComponent inTargetSlot;

		public UI_Window_SaveSanctuaryLook <>4__this;

		public string inName;

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
	private UI_LazyItemList_SanctuaryLookSaving _itemList;

	private SanctuaryLookItemComponent _lookToSave;

	public static void OpenWindow(SanctuaryLookItemComponent inLookToSave)
	{
	}

	public static void QueueWindow(SanctuaryLookItemComponent inLookToSave)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(SanctuaryLookItemComponent inLookToSave)
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

	[AsyncStateMachine(typeof(<SaveLook>d__9))]
	public void SaveLook(SanctuaryLookItemComponent inTargetSlot, string inName)
	{
	}
}
