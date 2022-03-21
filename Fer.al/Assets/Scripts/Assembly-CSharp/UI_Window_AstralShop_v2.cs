using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_AstralShop_v2 : UI_Window
{
	public class Tab
	{
		public int tabIndex;

		public WWImage image;

		public WWButton button;

		public UI_ColorizedIcon colorIcon;

		public UI_Tooltip tooltip;

		public AstralShopCategoryDefComponent categoryDefComponent;

		public List<string> content;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SpawnShopItems>d__44 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_AstralShop_v2 <>4__this;

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
	private struct <SpawnShopItem>d__45 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public UI_Window_AstralShop_v2 <>4__this;

		public IAPItem inIAPItem;

		public CancellationToken inCancellationToken;

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
	private struct <SetupAsync>d__48 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_AstralShop_v2 <>4__this;

		public CancellationToken inToken;

		public bool inIAP;

		private TaskAwaiter<ShopListResponse> <>u__1;

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
	private struct <OnItemBuy>d__55 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public BuyItemResponse inMessage;

		public UI_Window_AstralShop_v2 <>4__this;

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
	[RootSelector("Astral Shop Category List", "CraftableItemChartData", false, false)]
	private string _astralShopCategoriestDefId;

	[SerializeField]
	[RootSelector("Astral Shop Debug", "GlobalChartData", false, false)]
	private string _astralShopDebugControlDefId;

	[SerializeField]
	[RootSelector("Astral Shop", "ShopChartData", false, false)]
	private string _shopDefId;

	[SerializeField]
	[RootSelector("IAP Category", "CraftableItemChartData", false, false)]
	private string _iapCategoryDefId;

	[SerializeField]
	[RootSelector("Featured Category", "CraftableItemChartData", false, false)]
	private string _featuredCategoryDefId;

	[SerializeField]
	[RootSelector("Season Pass Category", "CraftableItemChartData", false, false)]
	private string _seasonPassCategoryDefId;

	[SerializeField]
	[RootSelector("Display Mods - Unowned Avatars", "GlobalChartData", false, false)]
	private string _displayModsForUnownedAvatarsDefId;

	[SerializeField]
	[RootSelector("Disable Empty Tabs", "GlobalChartData", false, false)]
	private string _displayEmptyTabsDefId;

	[SerializeField]
	private GridLayoutGroup _tabGrid;

	[SerializeField]
	private GameObject _tabPrefab;

	[SerializeField]
	private WWTextMeshProUGUI _tabTitle;

	[SerializeField]
	private Color _tabHighlightColor;

	[SerializeField]
	private Color _tabBaseColor;

	[SerializeField]
	private UI_IAPShopItem _shopItemPrefab;

	[SerializeField]
	private Transform _shopItemParent;

	[SerializeField]
	private UI_LazyItemList_AstralShop_v2 _itemListElements;

	[SerializeField]
	private RectTransform _itemListElementsRect;

	private float _scrollSpeed;

	private string[] _shopItemIds;

	private List<UI_IAPShopItem> _iapItems;

	private Tab _currentTab;

	private bool? _displayEmptyTabs;

	private bool? _displayModsForUnownedAvatars;

	public List<Tab> _tabs;

	private CancellationTokenSource _cancellationTokenSource;

	private bool _setupCompleted;

	public string ShopDefId
	{
		get
		{
			return null;
		}
	}

	private bool displayEmptyTabs
	{
		get
		{
			return default(bool);
		}
	}

	private bool displayModsForUnownedAvatars
	{
		get
		{
			return default(bool);
		}
	}

	public static void OpenWindow(bool inIAP)
	{
	}

	public static void QueueWindow(bool inIAP)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(bool inIAP)
	{
	}

	private void SetupAstralShopCategories()
	{
	}

	private void ClearData()
	{
	}

	public void GoToIAP()
	{
	}

	public void BtnClicked_Tab(Tab inTab)
	{
	}

	private bool CategoryExistsInItems(AstralShopCategoryDefComponent inAstralShopCategoryDefComponent)
	{
		return default(bool);
	}

	private bool IsSeasonPass(AstralShopCategoryRefDefComponent inAstralShopCategoryRefDefComponent)
	{
		return default(bool);
	}

	private void BtnClicked_Tab_IAP()
	{
	}

	[AsyncStateMachine(typeof(<SpawnShopItems>d__44))]
	private void SpawnShopItems()
	{
	}

	[AsyncStateMachine(typeof(<SpawnShopItem>d__45))]
	private UniTask SpawnShopItem(IAPItem inIAPItem, CancellationToken inCancellationToken)
	{
		return default(UniTask);
	}

	private void ClearIAPs()
	{
	}

	private bool HasLookSlot(BaseDef inDef)
	{
		return default(bool);
	}

	[AsyncStateMachine(typeof(<SetupAsync>d__48))]
	private void SetupAsync(CancellationToken inToken, bool inIAP)
	{
	}

	private void SetShopItemIds()
	{
	}

	private void ClearTabContent()
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

	public override void MOnDestroy()
	{
	}

	[AsyncStateMachine(typeof(<OnItemBuy>d__55))]
	private void OnItemBuy(BuyItemResponse inMessage)
	{
	}

	private void OnDetailWindowOpened(WindowOpenedMessage inMessage)
	{
	}

	private void OnDetailWindowClosed(WindowClosedMessage inMessage)
	{
	}

	public static void SetupImage(UI_ItemImage inImage, BaseDef inDef, bool inDetails, bool inSeasonPass, bool inForce3D)
	{
	}

	public static float GetImageScale(RectTransform inImageRect, float inWidth, float inHeight, bool inSeasonPass = false)
	{
		return default(float);
	}
}
