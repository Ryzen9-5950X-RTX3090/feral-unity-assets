using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_TradeLobbyItem : UI_LazyItemList<Item>
{
	[SerializeField]
	private UI_LazyListItem_TradeLobbyItem _itemPrefabReference;

	[SerializeField]
	private UI_LazyListItemDetailPanel_TradeLobbyItem _detailPanelReference;

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

	protected override List<string> GetDataItemFilters(Item inData)
	{
		return null;
	}

	protected override List<string> GetDataItemTags(Item inData)
	{
		return null;
	}
}
