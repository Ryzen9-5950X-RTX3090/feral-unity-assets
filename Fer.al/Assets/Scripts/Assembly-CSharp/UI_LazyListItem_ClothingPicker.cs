using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_ClothingPicker : UI_LazyListItem<ActorClothingDefComponent>
{
	[SerializeField]
	private UI_ItemImage _itemImage;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	[Header("Rarity")]
	private UI_RarityBadge _rarityBadge;

	[SerializeField]
	[Header("Member")]
	private GameObject _memberGroup;

	public override void Setup(Action<UI_LazyListItem<ActorClothingDefComponent>> inOnClicked, Action<UI_LazyListItem<ActorClothingDefComponent>> inOnSelected, ActorClothingDefComponent inData, UI_LazyItemList<ActorClothingDefComponent> inItemList)
	{
	}

	private void OnEnable()
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}
}
