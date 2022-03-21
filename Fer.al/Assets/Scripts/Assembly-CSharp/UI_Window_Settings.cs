using System.Collections.Generic;
using UnityEngine;

public class UI_Window_Settings : UI_Window
{
	[SerializeField]
	private List<GameObject> _loggedInOnlyGroups;

	[SerializeField]
	private UI_TabGroup _tabGroup;

	private int? _lastSelectedTab;

	private bool _canConfirmGraphicsSettings
	{
		get
		{
			return default(bool);
		}
	}

	private int LastSelectedTab
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

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

	public void BtnClicked_GiveFeedback()
	{
	}

	public void BtnClicked_Logout()
	{
	}

	public void BtnClicked_Quit()
	{
	}

	public override void OnReceiveFocus()
	{
	}

	public override void OnLoseFocus()
	{
	}
}
