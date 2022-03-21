using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_AccordianItem : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private FeralButton _button;

	[SerializeField]
	private RectTransform _rectTransform;

	private Action<UI_AccordianItem> _onClicked;

	public FeralButton Button
	{
		get
		{
			return null;
		}
	}

	public RectTransform RectTransform
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	public void Setup(string inName, Action<UI_AccordianItem> inOnClicked)
	{
	}

	public void MarkAsSelected(bool inIsSelected)
	{
	}

	public void ClickItem()
	{
	}

	private void OnClicked()
	{
	}

	private void Reset()
	{
	}
}
