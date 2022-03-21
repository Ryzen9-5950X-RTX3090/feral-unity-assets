using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class UI_Window_Inventory : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnItemSelected>d__23 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_Inventory <>4__this;

		public Item inItem;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private UI_TabGroup _categoryTabGroup;

	[SerializeField]
	private List<UI_LazyItemList_ItemInventory> _itemLists;

	[SerializeField]
	private UI_LazyItemList_MiscItemInventory _miscItemList;

	[SerializeField]
	private UI_LazyListItemDetailPanel_ItemInventory _detailPanel;

	[SerializeField]
	private UI_StageSubjectPositioner _stagePositioner;

	private ActorInfo _currentActorInfoDraft;

	private UI_Stage_3DItem _itemStage;

	private bool _stageIsInitialized;

	public ActorInfo CurrentActorInfoDraft
	{
		get
		{
			return null;
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

	protected override void OnHide()
	{
	}

	protected override void OnShow()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage)
	{
	}

	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage)
	{
	}

	private void OnItemDyeResponse(ItemDyeResponse message)
	{
	}

	[AsyncStateMachine(typeof(<OnItemSelected>d__23))]
	private void OnItemSelected(Item inItem)
	{
	}

	private void OnCategoryTabSelected(int inTabIndex)
	{
	}
}
