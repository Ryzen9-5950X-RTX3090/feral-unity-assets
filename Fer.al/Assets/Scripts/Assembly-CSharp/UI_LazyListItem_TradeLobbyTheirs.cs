using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

public class UI_LazyListItem_TradeLobbyTheirs : UI_LazyListItem<Item>
{
	[SerializeField]
	[Header("General")]
	private RawImage _iconImage;

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

	private WW.Waiters.Waiter _iconLoadWaiter;

	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	public void RefreshQuantity()
	{
	}
}
