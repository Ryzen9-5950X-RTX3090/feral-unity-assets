using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyItemList_TradeLobbyMine : UI_LazyItemList<Item>
{
	[SerializeField]
	private UI_LazyListItem_TradeLobbyMine _itemPrefabReference;

	[SerializeField]
	private FeralButton _addItemBtn;

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

	protected override void PostListFilter(int inShownItemsCount, int inNextIndex)
	{
	}

	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage)
	{
	}

	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage)
	{
	}

	private void OnTradeReady(UserReadyStateChangedMessage inMessage)
	{
	}

	public void BtnClicked_AddItem()
	{
	}
}
