using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_TradeLobbyInventory : UI_LazyListItem<Item>
{
	[SerializeField]
	[Header("General")]
	private UI_ItemImage _itemImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	[Header("Member")]
	private GameObject _memberGroup;

	[SerializeField]
	[Header("Rarity")]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	[Header("Stackable")]
	private GameObject _ownedCountBadge;

	[SerializeField]
	private WWTextMeshProUGUI _ownedCount;

	[SerializeField]
	[Header("Beta")]
	private GameObject _betaGroup;

	private bool _isOffered;

	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList)
	{
	}

	protected override void OnClicked()
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	private void RefreshIsOffered(bool inFromSetup)
	{
	}

	public void RefreshQuantity()
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
