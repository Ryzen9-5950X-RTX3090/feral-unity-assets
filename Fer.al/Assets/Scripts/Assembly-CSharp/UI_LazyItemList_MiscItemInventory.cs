using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_MiscItemInventory : UI_LazyItemList<Item>
{
	[SerializeField]
	private UI_LazyListItemDetailPanel_Item _detailPanelPrefab;

	[SerializeField]
	private UI_LazyListItem_ItemInventory _itemPrefab;

	[SerializeField]
	private RectTransform _categoryDescription;

	[SerializeField]
	private GameObject _categorySpacer;

	private List<Item> _inventoryItems;

	public void Setup(List<Item> inItems)
	{
	}

	protected void OnDisable()
	{
	}

	public void SetupDefault()
	{
	}

	protected override void Setup()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected override void PostListFilter(int inShownItemsCount, int inNextIndex)
	{
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

	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference()
	{
		return null;
	}

	protected override List<Item> GetDataItems()
	{
		return null;
	}

	protected override UI_LazyListItem<Item> GetListItemPrefab()
	{
		return null;
	}

	protected override bool ItemMatchesCategory(LazyListItem inItem)
	{
		return default(bool);
	}

	private void OnInventoryListRemoved(InventoryListRemovedResponse inMessage)
	{
	}

	private void OnInventoryList(InventoryListResponse inMessage)
	{
	}

	private void ItemSelected(Item inSelectedItem)
	{
	}
}
