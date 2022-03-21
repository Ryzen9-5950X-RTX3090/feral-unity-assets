using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Window_SimpleItemList : UI_Window
{
	[SerializeField]
	private WWTextMeshProUGUI _headerText;

	[SerializeField]
	private UI_LazyItemList_ReadonlyItemList _itemList;

	public static void OpenWindow(string inHeaderText, List<Item> inItemList)
	{
	}

	public static void QueueWindow(string inHeaderText, List<Item> inItemList)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(string inHeaderText, List<Item> inItemList)
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
