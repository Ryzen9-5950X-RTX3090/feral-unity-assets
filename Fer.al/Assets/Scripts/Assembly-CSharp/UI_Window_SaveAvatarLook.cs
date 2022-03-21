using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;

public class UI_Window_SaveAvatarLook : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SaveLook>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public AvatarLookItemComponent inTargetSlot;

		public UI_Window_SaveAvatarLook <>4__this;

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
	private UI_LazyItemList_AvatarLookSaving _itemList;

	private AvatarLookItemComponent _lookToSave;

	public static void OpenWindow(AvatarLookItemComponent inLookToSave)
	{
	}

	public static void QueueWindow(AvatarLookItemComponent inLookToSave)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(AvatarLookItemComponent inLookToSave)
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
	public void SaveLook(AvatarLookItemComponent inTargetSlot, string inName)
	{
	}
}
