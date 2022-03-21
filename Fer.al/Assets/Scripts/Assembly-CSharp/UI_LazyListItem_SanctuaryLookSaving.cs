using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_SanctuaryLookSaving : UI_LazyListItem<SanctuaryLookItemComponent>
{
	[SerializeField]
	private UI_SanctuaryLookImage _itemImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	public override void Setup(Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnClicked, Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnSelected, SanctuaryLookItemComponent inData, UI_LazyItemList<SanctuaryLookItemComponent> inItemList)
	{
	}
}
