using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_TradeLobbyInventory : UI_LazyItemList<Item>
{
	[SerializeField]
	private UI_LazyListItem_TradeLobbyInventory _itemPrefabReference;

	private List<Item> _dataItems;

	protected override void Setup()
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

	protected override string GetDataItemName(Item inData)
	{
		return null;
	}

	protected override int GetDataItemRarity(Item inData)
	{
		return default(int);
	}

	protected override List<string> GetDataItemFilters(Item inData)
	{
		return null;
	}

	protected override List<string> GetDataItemTags(Item inData)
	{
		return null;
	}

	protected override long GetDataItemAge(Item inData)
	{
		return default(long);
	}

	protected override bool ItemMatchesCategory(LazyListItem inItem)
	{
		return default(bool);
	}

	protected override void SortData()
	{
	}

	protected override void SortNewToOld()
	{
	}
}
