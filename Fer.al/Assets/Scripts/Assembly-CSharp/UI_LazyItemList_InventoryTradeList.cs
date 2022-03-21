using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_InventoryTradeList : UI_LazyItemList<Item>
{
	[SerializeField]
	private UI_LazyListItem_InventoryTradeList _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_InventoryTradeList _detailPanelReference;

	private List<Item> _dataItems;

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

	private void OnTradeListUpdated(ItemAddedOrRemovedFromTradeList inMessage)
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
}
