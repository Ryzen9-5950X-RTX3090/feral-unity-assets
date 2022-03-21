using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItem_EyeDecal : UI_LazyListItem<BaseDef>
{
	[SerializeField]
	private WWImage _iconImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	private QRoutine _imageDownloadQRoutine;

	private ActorInfo ActorInfo
	{
		get
		{
			return null;
		}
	}

	public override void Setup(Action<UI_LazyListItem<BaseDef>> inOnClicked, Action<UI_LazyListItem<BaseDef>> inOnSelected, BaseDef inData, UI_LazyItemList<BaseDef> inItemList)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	public override void Refresh()
	{
	}
}
