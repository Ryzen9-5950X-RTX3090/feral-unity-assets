using System;
using UnityEngine;

public class UI_Window_ClothingPicker : UI_Window
{
	[SerializeField]
	private UI_LazyItemList_ClothingPicker _itemList;

	private Action<ActorClothingDefComponent> _onItemChosenCallback;

	public static void OpenWindow(Action<ActorClothingDefComponent> inOnItemChosenCallback)
	{
	}

	public static void QueueWindow(Action<ActorClothingDefComponent> inOnItemChosenCallback)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(Action<ActorClothingDefComponent> inOnItemChosenCallback)
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

	private void OnItemChosen(ActorClothingDefComponent inItem)
	{
	}
}
