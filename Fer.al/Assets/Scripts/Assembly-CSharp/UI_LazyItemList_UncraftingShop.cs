using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

public class UI_LazyItemList_UncraftingShop : UI_LazyItemList<Item>
{
	[SerializeField]
	private ItemType _itemType;

	[SerializeField]
	private UI_LazyListItem_ItemInventory _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_UncraftingShop _detailPanelReference;

	[SerializeField]
	private FeralButton _craftBtn;

	[SerializeField]
	private WWButton _skipAnimationBtn;

	[SerializeField]
	private float _craftAnimationTime;

	private List<Item> _dataItems;

	public Action<Item, int> OnItemUncraftInitiated;

	private UI_Window_Shop_Uncrafting _window;

	private WW.Waiters.Waiter _animationWaiter;

	private UI_Window_Shop_Uncrafting Window
	{
		get
		{
			return null;
		}
	}

	protected override void Setup()
	{
	}

	private void OnDisable()
	{
	}

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	protected override List<Item> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference()
	{
		return null;
	}

	protected override UI_LazyListItem<Item> GetListItemPrefab()
	{
		return null;
	}

	protected override long GetDataItemAge(Item inData)
	{
		return default(long);
	}

	protected override bool GetDataItemFav(Item inData)
	{
		return default(bool);
	}

	protected override string GetDataItemName(Item inData)
	{
		return null;
	}

	protected override List<string> GetDataItemFilters(Item inData)
	{
		return null;
	}

	protected override List<string> GetDataItemTags(Item inData)
	{
		return null;
	}

	protected override int GetDataItemRarity(Item inData)
	{
		return default(int);
	}

	protected override void SortData()
	{
	}

	protected override void SortNewToOld()
	{
	}

	protected override bool ItemMatchesCategory(LazyListItem inItem)
	{
		return default(bool);
	}

	public void BtnClicked_CraftSelectedItem()
	{
	}

	private void DoCraft(int inQuantity)
	{
	}

	private void OnInventoryItemRemoved(InventoryItemRemovedEvent inMessage)
	{
	}

	public void BtnClicked_SkipAnimation()
	{
	}
}
