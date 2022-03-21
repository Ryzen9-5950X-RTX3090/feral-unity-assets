using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using WW.Debug;

public class UI_Window_Shop_Uncrafting : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnItemSelected>d__21 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_Shop_Uncrafting <>4__this;

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
	private UI_TabGroup _tabGroup;

	[SerializeField]
	private UI_LazyItemList_UncraftingShop[] _itemLists;

	[SerializeField]
	private UI_StageSubjectPositioner _stagePositioner;

	private UI_Stage_UncraftingShop _stage;

	private Item _itemBeingUncrafted;

	private int _quantityBeingUncrafted;

	public UI_Stage_UncraftingShop Stage
	{
		get
		{
			return null;
		}
	}

	[DebugButton("Open Uncrafting Shop", "Shop", true, true)]
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

	protected override void DoDelayedOpenAnimation()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnCategoryTabSelected(int inTabIndex)
	{
	}

	private void OnStageLoaded(UIUncraftingShopStageLoadedMessage inMessage)
	{
	}

	private void OnStageInitialized(UIUncraftingShopStageInitializedMessage inMessage)
	{
	}

	protected virtual void OnItemCraftInitiated(Item inItem, int inQuantity)
	{
	}

	protected virtual void OnItemUncrafted(ItemUncraftResponse inResponse)
	{
	}

	[AsyncStateMachine(typeof(<OnItemSelected>d__21))]
	private void OnItemSelected(Item inItem)
	{
	}
}
