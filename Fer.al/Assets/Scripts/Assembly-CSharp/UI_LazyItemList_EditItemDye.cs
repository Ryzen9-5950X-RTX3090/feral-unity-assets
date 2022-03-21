using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_EditItemDye : UI_LazyItemList<Item>
{
	[SerializeField]
	private UI_LazyListItem_EditItemDye _listItemPrefab;

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

	public void Refresh()
	{
	}
}
