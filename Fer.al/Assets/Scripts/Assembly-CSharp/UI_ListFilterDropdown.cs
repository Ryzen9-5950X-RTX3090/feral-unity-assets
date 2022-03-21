using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ListFilterDropdown : UI_Panel
{
	public class CategorizedFilter
	{
		public string originalFilterString;

		public string category;

		public string filter;

		public CategorizedFilter(string originalFilterString)
		{
		}
	}

	[SerializeField]
	private CanvasGroup _dropdownCanvasGroup;

	[SerializeField]
	private Canvas _dropdownCanvas;

	[SerializeField]
	private Transform _content;

	[SerializeField]
	private FeralButton _dropdownToggleBtn;

	[SerializeField]
	private UI_ListFilterItem _filterItemPrefab;

	[SerializeField]
	private UI_ListFilterCategory _filterCategoryPrefab;

	[SerializeField]
	[InterfaceType(typeof(IFilterable))]
	private Object _autoFilterTarget;

	private List<CategorizedFilter> _filters;

	private IFilterable _filterTarget;

	private GameObject _blocker;

	public override void MAwake()
	{
	}

	public void Setup(IFilterable inFilterTarget)
	{
	}

	private void ToggleBtnClicked_Dropdown(bool inIsOn)
	{
	}

	public override void OnReceiveFocus()
	{
	}

	public override void OnLoseFocus()
	{
	}

	private UI_ListFilterCategory SpawnCategoryItem(string inCategory)
	{
		return null;
	}

	private UI_ListFilterItem SpawnFilterItem(CategorizedFilter inFilter, UI_ListFilterCategory inCategory)
	{
		return null;
	}

	private void OnFilterToggled(UI_ListFilterItem inFilterItem, bool inIsSelected)
	{
	}

	private void OnBackBtnPressed()
	{
	}

	private GameObject CreateBlocker(Canvas rootCanvas)
	{
		return null;
	}
}
