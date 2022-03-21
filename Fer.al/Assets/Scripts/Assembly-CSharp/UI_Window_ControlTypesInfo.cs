using System.Collections.Generic;
using UnityEngine;

public class UI_Window_ControlTypesInfo : UI_Window
{
	[SerializeField]
	[EnumList(typeof(GameSettingsManager.ControlSetting), 0.35f)]
	private List<GameObject> _controlTypeGroups;

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
}
