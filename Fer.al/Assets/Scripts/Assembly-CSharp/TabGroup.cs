using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TabGroup
{
	[SerializeField]
	public List<OldTab> tabs;

	[SerializeField]
	private int _defaultTabIndex;

	public Action<int, OldTab, bool> onTabSelected;

	private int _currentTabIndex;

	public int CurrentTabIndex
	{
		get
		{
			return default(int);
		}
	}

	public void Setup(Action<int, OldTab, bool> inOnTabSelected)
	{
	}

	public void SelectCurrentTab()
	{
	}

	public void SelectDefaultTab(bool inSelectedFromSetup = false)
	{
	}

	public void SelectTab(int inTabIndex, bool inSelectedFromSetup = false)
	{
	}

	public void SelectTab(OldTab inTab, bool inSelectedFromSetup = false)
	{
	}

	public void TabLeft()
	{
	}

	public void TabRight()
	{
	}

	private void TabClicked(OldTab inTab, bool inSelectedFromSetup = false)
	{
	}
}
