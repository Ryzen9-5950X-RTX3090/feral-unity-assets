using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_Window_DyeConfirmation : UI_Window
{
	[SerializeField]
	private Transform _dyeCostItemParent;

	[SerializeField]
	private UI_DyeCostItem _dyeCostItemPrefab;

	private Action<bool> _onConfirmationResult;

	public static void OpenWindow(List<ValueTuple<Item, int>> inDyeOperations, Action<bool> inOnConfirmationResult)
	{
	}

	public static void QueueWindow(List<ValueTuple<Item, int>> inDyeOperations, Action<bool> inOnConfirmationResult)
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(List<ValueTuple<Item, int>> inDyeOperations, Action<bool> inOnConfirmationResult)
	{
	}

	public void BtnClicked_Yes()
	{
	}

	public void BtnClicked_No()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}
}
