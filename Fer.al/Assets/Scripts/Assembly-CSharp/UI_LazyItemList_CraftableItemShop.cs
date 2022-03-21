using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

public class UI_LazyItemList_CraftableItemShop : UI_LazyItemList<BaseDef>
{
	[SerializeField]
	private UI_LazyListItemDetailPanel_CraftableItem_Shop _detailPanelPrefab;

	[SerializeField]
	private UI_LazyListItem_CraftableItem_Shop _itemPrefab;

	[SerializeField]
	private List<BaseDef> _itemDefs;

	[SerializeField]
	private FeralButton _craftBtn;

	[SerializeField]
	private WWButton _skipAnimationBtn;

	public Action<BaseDef, int> OnItemCraftInitiated;

	private List<BaseDef> _shopInventoryItemDefs;

	private List<BaseDef> _enigmaInventoryItemDefs;

	private UI_Window_Shop_Dye _window;

	private WW.Waiters.Waiter _animationWaiter;

	private string _shopFilterCategory;

	private string ShopFilterCategory
	{
		get
		{
			return null;
		}
	}

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Setup(string[] inItemDefIds)
	{
	}

	public void BtnClicked_CraftSelectedItem()
	{
	}

	private void DoCraft(int inQuantity)
	{
	}

	public void LongPress_Craft_Progress(float inProgress)
	{
	}

	public void LongPress_Craft_Cancel()
	{
	}

	public void BtnClicked_SkipAnimation()
	{
	}

	protected override void Setup()
	{
	}

	protected override long GetDataItemAge(BaseDef inData)
	{
		return default(long);
	}

	protected override bool GetDataItemFav(BaseDef inData)
	{
		return default(bool);
	}

	protected override string GetDataItemName(BaseDef inData)
	{
		return null;
	}

	protected override List<string> GetDataItemFilters(BaseDef inData)
	{
		return null;
	}

	protected override List<string> GetDataItemTags(BaseDef inData)
	{
		return null;
	}

	protected override int GetDataItemRarity(BaseDef inData)
	{
		return default(int);
	}

	protected override UI_LazyListItemDetailPanel<BaseDef> GetDetailPanelReference()
	{
		return null;
	}

	protected override List<BaseDef> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItem<BaseDef> GetListItemPrefab()
	{
		return null;
	}

	protected override bool ItemMatchesCategory(LazyListItem inItem)
	{
		return default(bool);
	}

	protected override bool ItemMatchesFilter(LazyListItem inItem, string inFilterCategory)
	{
		return default(bool);
	}

	protected override void SortData()
	{
	}

	protected override void SortNewToOld()
	{
	}

	private void OnInventoryItemsRemoved(InventoryListRemovedResponse inMessage)
	{
	}

	private void OnInventoryUpdated(InventoryListResponse inMessage)
	{
	}
}
