using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_SanctuaryLight : UI_LazyListItem<SanctuaryLightDefComponent>
{
	[SerializeField]
	private UI_ItemImage _itemImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	public override void Setup(Action<UI_LazyListItem<SanctuaryLightDefComponent>> inOnClicked, Action<UI_LazyListItem<SanctuaryLightDefComponent>> inOnSelected, SanctuaryLightDefComponent inData, UI_LazyItemList<SanctuaryLightDefComponent> inItemList)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	public override void Refresh()
	{
	}
}
