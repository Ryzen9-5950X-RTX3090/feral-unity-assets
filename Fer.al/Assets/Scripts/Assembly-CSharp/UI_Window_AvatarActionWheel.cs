using System.Collections.Generic;
using UnityEngine;

public class UI_Window_AvatarActionWheel : UI_Window
{
	[SerializeField]
	private List<UI_AvatarActionWheelItem> _avatarActionWheelItems;

	[SerializeField]
	private Vector2 _windowScale;

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup()
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

	private void OnHideHUDCommand(HideHUDCommand inCommand)
	{
	}
}
