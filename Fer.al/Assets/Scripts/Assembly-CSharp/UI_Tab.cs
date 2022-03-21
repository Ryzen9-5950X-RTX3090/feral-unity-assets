using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class UI_Tab
{
	public FeralButton button;

	public GameObject gameObject;

	[RootSelectorCompact("Header Text", "LocalizationChartData", null, false, false)]
	public string localizedHeaderDefId;

	private CanvasGroup _canvasGroup;

	private bool _active;

	private UI_TabGroup _group;

	public void Setup(bool inActive, UI_TabGroup inGroup)
	{
	}

	public void SetActive(bool inActive)
	{
	}
}
