using System;
using UnityEngine;
using UnityEngine.UI;

public class VisibilityCalculator
{
	private LazyLayoutGroup _layoutGroup;

	private ScrollRect _scrollRect;

	private Action<int, bool> _itemVisibilityCallback;

	private int _maskingAxis;

	public VisibilityCalculator(LazyLayoutGroup inLayout, ScrollRect inScrollRect, Action<int, bool> inItemVisibilityCallback, int inMaskingAxis = 1)
	{
	}

	private void OnScroll(Vector2 inScrollPosition)
	{
	}

	private void OnLayoutChanged()
	{
	}

	public void CalculateVisibility()
	{
	}
}
