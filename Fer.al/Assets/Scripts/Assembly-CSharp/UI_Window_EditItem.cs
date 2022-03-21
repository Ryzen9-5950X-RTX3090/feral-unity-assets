using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_EditItem : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnStageInitialized>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_EditItem <>4__this;

		private TaskAwaiter <>u__1;

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
	private struct <SetStageFromExisting>d__16 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_EditItem <>4__this;

		public UI_Stage_3DItem inStage;

		private TaskAwaiter <>u__1;

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
	private struct <ToggleBtnClicked_ShowAvatarPreview>d__17 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_EditItem <>4__this;

		public bool inIsOn;

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
	private UI_StageSubjectPositioner _stagePositioner;

	[SerializeField]
	private WWTextMeshProUGUI _itemNameText;

	[SerializeField]
	private FeralButton _avatarPreviewToggleBtn;

	private bool _isStageOwner;

	private UI_Stage_3DItem _itemStage;

	private Item _item;

	public Item Item
	{
		get
		{
			return null;
		}
	}

	public static void OpenWindow(Item inItemToEdit)
	{
	}

	public static void QueueWindow(Item inItemToEdit)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(Item inItemToEdit)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnStageInitialized>d__15))]
	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<SetStageFromExisting>d__16))]
	private void SetStageFromExisting(UI_Stage_3DItem inStage)
	{
	}

	[AsyncStateMachine(typeof(<ToggleBtnClicked_ShowAvatarPreview>d__17))]
	public void ToggleBtnClicked_ShowAvatarPreview(bool inIsOn)
	{
	}
}
