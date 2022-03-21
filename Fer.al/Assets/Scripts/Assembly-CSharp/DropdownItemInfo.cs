using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class DropdownItemInfo
{
	[SerializeField]
	[FormerlySerializedAs("text")]
	private string _text;

	[RootSelector("Text", "LocalizationChartData", false, false)]
	public string localizationDefId;

	public Sprite sprite;

	public string Text
	{
		get
		{
			return null;
		}
	}
}
