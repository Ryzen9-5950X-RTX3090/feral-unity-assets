using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

public abstract class UI_LazyItemList<T> : MonoBehaviour, IFilterable where T : class
{
	public enum AutoSetupMethod
	{
		None,
		Start,
		Enable
	}

	public enum Filter
	{
		All,
		Rare,
		WishList
	}

	public enum SortMethod
	{
		AToZ,
		ZToA,
		CommonToRare,
		RareToCommon,
		FavToNot,
		NotToFav
	}

	public class LazyListItem
	{
		public LazyLayoutElement layoutElement;

		public T data;

		public UI_LazyListItem<T> uiItem;

		private bool _isSearchMode;

		public string Name;

		public List<string> Filters;

		public List<string> Tags;

		public bool IsSearchMode
		{
			get
			{
				return default(bool);
			}
		}

		public LazyListItem(LazyLayoutElement inLayoutElement, T inData, string inName, List<string> inFilters, List<string> inTags)
		{
		}

		public void SetUIItem(UI_LazyListItem<T> inUIItem)
		{
		}

		public void SetSearchMode(bool inIsSearchMode)
		{
		}
	}

	public class ItemPool
	{
		private Transform _itemParent;

		private UI_LazyListItem<T> _itemPrefab;

		private List<UI_LazyListItem<T>> _availableItems;

		private List<UI_LazyListItem<T>> _itemsInUse;

		public ItemPool(Transform inItemParent, UI_LazyListItem<T> inItemPrefab, int inInitialPoolSize = 50)
		{
		}

		public UI_LazyListItem<T> GetItemFromPool()
		{
			return null;
		}

		public void ReturnItemToPool(UI_LazyListItem<T> inItem)
		{
		}

		public List<UI_LazyListItem<T>> GetAllLivingItems()
		{
			return null;
		}

		private void SpawnItem()
		{
		}
	}

	[SerializeField]
	private LazyLayoutGroup _layout;

	[SerializeField]
	private bool _allowLayoutAnimation;

	[SerializeField]
	protected ScrollRect _scrollRect;

	[SerializeField]
	protected int _itemsPerRow;

	[SerializeField]
	protected Vector2 _cellSize;

	[SerializeField]
	protected CanvasGroup _noItemsGroup;

	[SerializeField]
	[Tooltip("In this case the detail panel will not be a prefab, and will not be in-line with the items in the scroll rect")]
	private bool _detailPanelIsExternal;

	[SerializeField]
	[Tooltip("if true the concrete itemlist will be responsible for populating it's own data in the setup funciton. Otherwise you will need to create a setup functionthat takes the data set as a parameter and calls the built in setup function.")]
	private AutoSetupMethod _autoSetupMethod;

	[SerializeField]
	private bool _scrollToClickedItem;

	protected int _currentCategoryIndex;

	[SerializeField]
	[RootSelector("Default Supported Filters", "ListChartData", false, false)]
	protected string _supportedFiltersListDefId;

	protected List<string> _supportedFilters;

	protected Dictionary<string, HashSet<string>> _currentFilters;

	protected string _currentSearchString;

	private WW.Waiters.Waiter _searchWaiter;

	protected int _currentSortMethod;

	protected List<LazyListItem> _items;

	protected Dictionary<LazyLayoutElement, LazyListItem> _itemsByLayoutElement;

	protected Dictionary<T, LazyListItem> _itemsByData;

	protected T _currentlySelectedData;

	protected Tweener _scrollTween;

	protected VisibilityCalculator _visibilityCalculator;

	protected ItemPool _itemPool;

	protected List<LazyLayoutElement> _extraBottomElements;

	protected int _firstItemSiblingIndexOffset;

	public Action<T> OnItemSelected;

	public Action<T> OnItemClicked;

	public Action OnCalculateNavigation;

	public LazyLayoutGroup Layout
	{
		get
		{
			return null;
		}
	}

	public ScrollRect ScrollRect
	{
		get
		{
			return null;
		}
	}

	public int ItemsPerRow
	{
		get
		{
			return default(int);
		}
	}

	public CanvasGroup noItemsGroup
	{
		get
		{
			return null;
		}
	}

	public int CategoryIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public List<string> SupportedFilters
	{
		get
		{
			return null;
		}
	}

	public string CurrentSearchString
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int CurrentSortMethod
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public List<LazyListItem> Items
	{
		get
		{
			return null;
		}
	}

	private List<T> DataItems
	{
		get
		{
			return null;
		}
	}

	public T CurrentlySelectedData
	{
		get
		{
			return null;
		}
	}

	public UI_LazyListItem<T> CurrentlySelectedItem
	{
		get
		{
			return null;
		}
	}

	public ItemPool Pool
	{
		get
		{
			return null;
		}
	}

	public UI_LazyListItemDetailPanel<T> DetailPanel
	{
		get
		{
			return null;
		}
	}

	private UI_LazyListItem<T> ItemPrefab
	{
		get
		{
			return null;
		}
	}

	public void AddFilter(string inFilter)
	{
	}

	public void RemoveFilter(string inFilter)
	{
	}

	public void ClearFilters()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void Setup()
	{
	}

	protected virtual void SetupItem(UI_LazyListItem<T> inUIItem, Action<UI_LazyListItem<T>> inOnClicked, Action<UI_LazyListItem<T>> inOnSelected, LazyListItem inListItem)
	{
	}

	protected virtual void SetupSupportedFilters()
	{
	}

	private void SpawnListItems()
	{
	}

	private void SpawnDetailPanel()
	{
	}

	private void SpawnNoItemsGroup()
	{
	}

	protected virtual List<string> CreateCategoryNames()
	{
		return null;
	}

	private void SetItemVisible(LazyLayoutElement inLayoutElement, bool inIsVisible)
	{
	}

	private void ItemClicked(UI_LazyListItem<T> inItem)
	{
	}

	private void ItemSelected(UI_LazyListItem<T> inItem)
	{
	}

	protected virtual int CalcDesiredDetailIndex(UI_LazyListItem<T> inItemToDetail)
	{
		return default(int);
	}

	private void ScrollToSelectedItem()
	{
	}

	protected void ScrollToItem(LazyListItem inItem, bool inInstant = false, float inOffset = 0f)
	{
	}

	protected void ScrollToTop()
	{
	}

	protected virtual void SortData()
	{
	}

	protected virtual void SortAToZ()
	{
	}

	protected virtual void SortZToA()
	{
	}

	protected virtual string GetDataItemName(T inData)
	{
		return null;
	}

	protected virtual List<string> GetDataItemFilters(T inData)
	{
		return null;
	}

	protected virtual List<string> GetDataItemTags(T inData)
	{
		return null;
	}

	protected virtual void SortCommonToRare()
	{
	}

	protected virtual void SortRareToCommon()
	{
	}

	protected virtual int GetDataItemRarity(T inData)
	{
		return default(int);
	}

	protected virtual void SortFavToNotFav()
	{
	}

	protected virtual void SortNotFavToFav()
	{
	}

	protected virtual bool GetDataItemFav(T inData)
	{
		return default(bool);
	}

	protected virtual void SortNewToOld()
	{
	}

	protected virtual void SortOldToNew()
	{
	}

	protected virtual long GetDataItemAge(T inData)
	{
		return default(long);
	}

	protected virtual string GetDataItemId(T inData)
	{
		return null;
	}

	protected virtual void CalculateUINavigation()
	{
	}

	protected abstract UI_LazyListItem<T> GetListItemPrefab();

	protected abstract UI_LazyListItemDetailPanel<T> GetDetailPanelReference();

	protected abstract List<T> GetDataItems();

	protected virtual bool ItemMatchesCategory(LazyListItem inItem)
	{
		return default(bool);
	}

	protected virtual bool ItemMatchesFilter(LazyListItem inItem)
	{
		return default(bool);
	}

	protected virtual bool ItemMatchesFilter(LazyListItem inItem, string inFilterCategory)
	{
		return default(bool);
	}

	protected virtual bool ItemMatchesSearch(LazyListItem inItem)
	{
		return default(bool);
	}

	protected void InitializeSiblingIndicies()
	{
	}

	public void FilterList(bool inInstant = true, bool inSkipSort = false)
	{
	}

	protected virtual void PostListFilter(int inShownItemsCount, int inNextIndex)
	{
	}

	protected virtual LazyLayoutInfo CreateLayoutInfo(T inItem)
	{
		return null;
	}

	public void SelectItem(T inItem)
	{
	}

	public void DeselectCurrentItem()
	{
	}

	public bool AddItem(T inItem, bool inFromSetup = false, int inSiblingIndex = -1)
	{
		return default(bool);
	}

	public void RemoveItem(T inItem)
	{
	}

	public void ClearAllData()
	{
	}
}
