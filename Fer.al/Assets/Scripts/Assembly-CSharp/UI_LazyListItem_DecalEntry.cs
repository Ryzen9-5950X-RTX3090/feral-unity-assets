using System;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LazyListItem_DecalEntry : UI_LazyListItem<ActorInfoDecalEntry>
{
	[SerializeField]
	private WWImage _decalIconImage;

	[SerializeField]
	private WWImage _decalIconHighlightImage;

	[SerializeField]
	private UIHsvModifier _iconHSVModifier;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private FeralButton _isVisible;

	public override void Setup(Action<UI_LazyListItem<ActorInfoDecalEntry>> inOnClicked, Action<UI_LazyListItem<ActorInfoDecalEntry>> inOnSelected, ActorInfoDecalEntry inData, UI_LazyItemList<ActorInfoDecalEntry> inItemList)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	public void RefreshIcon()
	{
	}

	public void RefreshIconColor()
	{
	}

	public void ToggleBtnClicked_ShowHide(bool inIsOn)
	{
	}

	public void BtnClicked_Remove()
	{
	}
}
