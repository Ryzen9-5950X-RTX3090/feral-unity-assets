using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ListFilterItem : MonoBehaviour
{
	[SerializeField]
	private FeralButton _toggleBtn;

	[SerializeField]
	private WWTextMeshProUGUI _filterNameText;

	private UI_ListFilterDropdown.CategorizedFilter _filter;

	private Action<UI_ListFilterItem, bool> OnSelected;

	public UI_ListFilterDropdown.CategorizedFilter Filter
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void Setup(UI_ListFilterDropdown.CategorizedFilter inFilter, Action<UI_ListFilterItem, bool> inOnSelectedCallback)
	{
	}

	private void ToggleBtnClicked_SelectFilter(bool inIsOn)
	{
	}
}
