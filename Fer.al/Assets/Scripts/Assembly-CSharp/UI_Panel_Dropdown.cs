using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UI_Panel_Dropdown : UI_Panel
{
	[Serializable]
	public class OnDropdownItemSelectedEvent : UnityEvent<int>
	{
	}

	[SerializeField]
	private CanvasGroup _dropdownCanvasGroup;

	[SerializeField]
	private UI_DropdownItem _mainItem;

	[SerializeField]
	private UI_DropdownItem _prefabItem;

	[SerializeField]
	private Canvas _dropdownCanvas;

	[SerializeField]
	private bool _autoSetup;

	[SerializeField]
	private List<UI_DropdownItem> _dropdownItems;

	[SerializeField]
	private List<DropdownItemInfo> _itemInfos;

	[SerializeField]
	private OnDropdownItemSelectedEvent _onDropdownItemSelected;

	private int _selectedIndex;

	private int _dontShowIndex;

	private bool _hideSelectedItems;

	private GameObject m_Blocker;

	public int DontShowIndex
	{
		get
		{
			return default(int);
		}
	}

	public bool HidingSelectedItems
	{
		get
		{
			return default(bool);
		}
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void OnReceiveFocus()
	{
	}

	public override void OnLoseFocus()
	{
	}

	public void SetupItems(bool inIsInitialSetup, int inIndexToSelect = -1)
	{
	}

	public void HideValueAtIndex(int inIndex)
	{
	}

	public void HideSelectedItems(bool inHide = true)
	{
	}

	private void AssignNavigation()
	{
	}

	private void OnDropdownItemClicked(UI_DropdownItem inItem)
	{
	}

	public void ForceSetMainItem(int itemNumber)
	{
	}

	private void OnMainItemClicked(UI_DropdownItem inItem)
	{
	}

	private void OnBackBtnPressed()
	{
	}

	protected virtual GameObject CreateBlocker(Canvas rootCanvas)
	{
		return null;
	}

	protected virtual void DestroyBlocker(GameObject blocker)
	{
	}
}
