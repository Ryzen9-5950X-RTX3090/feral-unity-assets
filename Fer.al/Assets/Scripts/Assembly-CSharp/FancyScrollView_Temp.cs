using System;
using System.Collections.Generic;
using FancyScrollView;
using UnityEngine;

public class FancyScrollView_Temp : FancyScrollView<int, FancyScrollViewContext_Temp>
{
	[SerializeField]
	private ScrollPositionController _scrollPositionController;

	private Action<int> onSelectedIndexChanged;

	private int _paddingCells;

	private void Awake()
	{
	}

	public void UpdateData(List<int> data, bool inPaddingNeeded)
	{
	}

	public void UpdateSelection(int index, int direction = 0)
	{
	}

	public void OnSelectedIndexChanged(Action<int> onSelectedIndexChanged)
	{
	}

	public void SelectNextCell()
	{
	}

	public void SelectPrevCell()
	{
	}

	private void HandleItemSelected(int selectedItemIndex)
	{
	}

	private void OnPressedCell(FancyScrollViewCell_Temp cell)
	{
	}
}
