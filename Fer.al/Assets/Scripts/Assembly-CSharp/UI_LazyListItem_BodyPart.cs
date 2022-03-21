using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_BodyPart : UI_LazyListItem<ActorBodyPartDefComponent>
{
	[SerializeField]
	private UI_ItemImage _itemImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	private ActorInfo ActorInfo
	{
		get
		{
			return null;
		}
	}

	public override void Setup(Action<UI_LazyListItem<ActorBodyPartDefComponent>> inOnClicked, Action<UI_LazyListItem<ActorBodyPartDefComponent>> inOnSelected, ActorBodyPartDefComponent inData, UI_LazyItemList<ActorBodyPartDefComponent> inItemList)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	public override void Refresh()
	{
	}
}
