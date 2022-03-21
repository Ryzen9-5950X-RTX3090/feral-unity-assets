using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_AvatarLookSaving : UI_LazyListItem<AvatarLookItemComponent>
{
	[SerializeField]
	private UI_AvatarLookImage _itemImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	public override void Setup(Action<UI_LazyListItem<AvatarLookItemComponent>> inOnClicked, Action<UI_LazyListItem<AvatarLookItemComponent>> inOnSelected, AvatarLookItemComponent inData, UI_LazyItemList<AvatarLookItemComponent> inItemList)
	{
	}
}
