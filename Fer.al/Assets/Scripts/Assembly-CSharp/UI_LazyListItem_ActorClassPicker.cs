using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_ActorClassPicker : UI_LazyListItem<ActorClassDefComponent>
{
	[SerializeField]
	private UI_ItemImage _itemImage;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	public override void Setup(Action<UI_LazyListItem<ActorClassDefComponent>> inOnClicked, Action<UI_LazyListItem<ActorClassDefComponent>> inOnSelected, ActorClassDefComponent inData, UI_LazyItemList<ActorClassDefComponent> inItemList)
	{
	}
}
