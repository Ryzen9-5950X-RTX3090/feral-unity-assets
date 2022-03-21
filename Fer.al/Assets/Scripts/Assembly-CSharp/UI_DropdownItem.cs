using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_DropdownItem : MonoBehaviour
{
	[SerializeField]
	private WWButton _button;

	[SerializeField]
	private WWTextMeshProUGUI _text;

	[SerializeField]
	private WWImage _iconImage;

	private DropdownItemInfo _info;

	private Action<UI_DropdownItem> _onClickedAction;

	public WWButton Button
	{
		get
		{
			return null;
		}
	}

	public DropdownItemInfo Info
	{
		get
		{
			return null;
		}
	}

	public void Setup(DropdownItemInfo inInfo, [Optional] Action<UI_DropdownItem> inOnClickedAction)
	{
	}

	private void Start()
	{
	}

	private void OnClick()
	{
	}
}
