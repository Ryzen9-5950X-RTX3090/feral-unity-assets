using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_Window_ExpansionShopConfirmation : UI_Window
{
	[SerializeField]
	private GameObject _itemRemovalWarning;

	[SerializeField]
	private Transform _costItemParent;

	[SerializeField]
	private UI_SanctuaryExpansionCostItem _costItemPrefab;

	private Action<bool> _onConfirmationResult;

	public static void OpenWindow(List<ValueTuple<BaseDef, int>> inCost, Action<bool> inOnConfirmationResult)
	{
	}

	public static void QueueWindow(List<ValueTuple<BaseDef, int>> inCost, Action<bool> inOnConfirmationResult)
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(List<ValueTuple<BaseDef, int>> inCost, Action<bool> inOnConfirmationResult)
	{
	}

	public void BtnClicked_Yes()
	{
	}

	public void BtnClicked_No()
	{
	}
}
