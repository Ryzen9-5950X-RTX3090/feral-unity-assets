using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_EditItemDye : UI_LazyListItem<Item>
{
	[SerializeField]
	private UI_EditItemPanel_Dyes _dyePanel;

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
	private GameObject _ownedCountBadge;

	[SerializeField]
	private WWTextMeshProUGUI _ownedCount;

	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList)
	{
	}

	public override void Refresh()
	{
	}

	public void RefreshQuantity()
	{
	}
}
