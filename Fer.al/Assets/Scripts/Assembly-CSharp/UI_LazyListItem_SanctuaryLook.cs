using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_SanctuaryLook : UI_LazyListItem<SanctuaryLookItemComponent>
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private UI_SanctuaryLookImage _itemImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	public override void Setup(Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnClicked, Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnSelected, SanctuaryLookItemComponent inData, UI_LazyItemList<SanctuaryLookItemComponent> inItemList)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Refresh()
	{
	}

	private void OnSanctuaryLookSave(SanctuaryXtHandler.SanctuaryLookSaveResponse inMessage)
	{
	}
}
