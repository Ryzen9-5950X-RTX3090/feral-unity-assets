using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.DeInspektor.Attributes;
using TMPro;
using UniRx.Async;
using UnityEngine;
using WW.Debug;

public class UI_Window_Shop_CraftableItem : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnSecretCraft>d__19 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_Shop_CraftableItem <>4__this;

		public BuyItemResponse inMessage;

		private <>c__DisplayClass19_0 <>8__1;

		private UniTask.Awaiter <>u__1;

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
	private struct <SetupShopContent>d__21 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_Shop_CraftableItem <>4__this;

		private TaskAwaiter<ShopListResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	[Header("Craftable Item Shop")]
	[RootSelector("Shop Content", "ShopChartData", false, false)]
	protected string _shopDefId;

	[SerializeField]
	protected UI_LazyItemList_CraftableItemShop _itemList;

	[SerializeField]
	protected UI_TabGroup _tabGroup;

	[SerializeField]
	protected WWTextMeshProUGUI _sectionLabelText;

	[SerializeField]
	protected Transform _secretCraftingParent;

	[SerializeField]
	protected UI_ShopDialoguePanel _dialoguePanel;

	protected UI_Stage _uiStage;

	protected ShopContentDefComponent _shopDef;

	protected bool _stageError;

	[DebugButton("Open Shop", "UI", true, true)]
	public static void OpenWindow([Optional] ShopContentDefComponent inShopDef)
	{
	}

	public static void QueueWindow([Optional] ShopContentDefComponent inShopDef)
	{
	}

	public static void CloseWindow()
	{
	}

	public virtual void Setup([Optional] ShopContentDefComponent inShopDef)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnOpenComplete()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	protected override void DoDelayedOpenAnimation()
	{
	}

	protected virtual void OnItemCraftInitiated(BaseDef inDef, int inQuantity)
	{
	}

	protected virtual void OnItemCrafted(BuyItemResponse inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnSecretCraft>d__19))]
	[DeMethodButton(null, 0, new object[] { })]
	protected virtual void OnSecretCraft(BuyItemResponse inMessage)
	{
	}

	public override void MOnDestroy()
	{
	}

	[AsyncStateMachine(typeof(<SetupShopContent>d__21))]
	private void SetupShopContent()
	{
	}
}
