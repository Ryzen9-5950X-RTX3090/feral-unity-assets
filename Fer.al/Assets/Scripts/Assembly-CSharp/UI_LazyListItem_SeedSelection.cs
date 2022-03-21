using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_SeedSelection : UI_LazyListItem<Item>
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
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
	private WWTextMeshProUGUI _ownedCount;

	[SerializeField]
	[Header("Unread")]
	private GameObject _unreadGroup;

	private UI_LazyItemList_SeedSelection _seedItemList;

	protected override void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	public override void Refresh()
	{
	}

	public void RefreshQuantity()
	{
	}

	public void RefreshUnread()
	{
	}

	private void OnEnable()
	{
	}

	private void OnItemChanged(InventoryItemChangedEvent inMessage)
	{
	}
}
