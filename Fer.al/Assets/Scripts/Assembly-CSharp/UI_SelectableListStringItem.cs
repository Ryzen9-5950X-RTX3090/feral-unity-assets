using System;
using TMPro;
using UnityEngine;

public class UI_SelectableListStringItem : UI_SelectableListItem<string>
{
	[SerializeField]
	private WWTextMeshProUGUI _text;

	public override void Setup(string inData, Action<UI_SelectableListItem<string>> inOnClicked, Action<UI_SelectableListItem<string>> inOnLongPressed)
	{
	}
}
