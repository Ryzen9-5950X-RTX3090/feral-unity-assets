using System;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_NPCDef : UI_LazyListItem<BaseDef>
{
	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	public override void Setup(Action<UI_LazyListItem<BaseDef>> inOnClicked, Action<UI_LazyListItem<BaseDef>> inOnSelected, BaseDef inData, UI_LazyItemList<BaseDef> inItemList)
	{
	}

	protected override void OnClicked()
	{
	}
}
