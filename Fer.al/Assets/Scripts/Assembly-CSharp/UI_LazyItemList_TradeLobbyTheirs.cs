using System.Collections.Generic;
using UnityEngine;

public class UI_LazyItemList_TradeLobbyTheirs : UI_LazyItemList<Item>
{
	[SerializeField]
	private UI_LazyListItem_TradeLobbyTheirs _itemPrefabReference;

	private List<Item> _dataItems;

	protected override void Setup()
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

	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage)
	{
	}

	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage)
	{
	}
}
