using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

[Serializable]
public class UI_TabGroup : MonoBehaviour
{
	[SerializeField]
	private int _defaultIndex;

	[SerializeField]
	private bool _autoSetup;

	[SerializeField]
	private bool _allowSelectCurrent;

	[SerializeField]
	private bool _allowNoneSelected;

	[SerializeField]
	private bool _selectNoneBeforeSwitching;

	[SerializeField]
	private bool _controlGameObjectActivation;

	[SerializeField]
	private WWSmoothLayout _smoothLayout;

	[SerializeField]
	private WWSmoothLayout _rootSmoothLayout;

	[SerializeField]
	[Tooltip("Optional for assigning a header text per tab")]
	private WWTextMeshProUGUI _headerText;

	[SerializeField]
	private List<UI_Tab> _tabs;

	private Action<int> _onTabSelected;

	private bool _isSetup;

	private int _currentSelected;

	public bool AllowSelectCurrent
	{
		get
		{
			return default(bool);
		}
	}

	public bool AllowNoneSelected
	{
		get
		{
			return default(bool);
		}
	}

	public bool ControlGameObjectActivation
	{
		get
		{
			return default(bool);
		}
	}

	public WWSmoothLayout SmoothLayout
	{
		get
		{
			return null;
		}
	}

	public WWSmoothLayout RootSmoothLayout
	{
		get
		{
			return null;
		}
	}

	public WWTextMeshProUGUI HeaderText
	{
		get
		{
			return null;
		}
	}

	public List<UI_Tab> Tabs
	{
		get
		{
			return null;
		}
	}

	public int CurrentSelected
	{
		get
		{
			return default(int);
		}
	}

	private void OnEnable()
	{
	}

	public void Setup(int inSelectedIndex = -1, [Optional] Action<int> inOnTabSelected)
	{
	}

	private void DoTabClicked(UI_Tab inClickedTab, int inTabIndex)
	{
	}

	public void OnTabClicked(UI_Tab inClickedTab)
	{
	}

	public void ClickTab(int inTabIndex)
	{
	}

	public void SetTabEnabled(int inTabIndex, bool inEnabled)
	{
	}
}
