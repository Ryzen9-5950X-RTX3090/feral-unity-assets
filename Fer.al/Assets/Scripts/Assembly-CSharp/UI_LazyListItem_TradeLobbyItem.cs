using System;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItem_TradeLobbyItem : UI_LazyListItem<Item>
{
	[SerializeField]
	private RawImage _iconImage;

	private bool _isOffered;

	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList)
	{
	}

	protected override void OnClicked()
	{
	}

	private void RefreshIsOffered()
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage)
	{
	}

	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage)
	{
	}
}
