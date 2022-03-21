using System;
using UnityEngine;

public class UI_Window_ActorClassPicker : UI_Window
{
	[SerializeField]
	private UI_LazyItemList_ActorClassPicker _itemList;

	private Action<ActorClassDefComponent> _onItemChosenCallback;

	public static void OpenWindow(Action<ActorClassDefComponent> inOnItemChosenCallback)
	{
	}

	public static void QueueWindow(Action<ActorClassDefComponent> inOnItemChosenCallback)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(Action<ActorClassDefComponent> inOnItemChosenCallback)
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

	private void OnItemChosen(ActorClassDefComponent inItem)
	{
	}
}
