using UnityEngine;

public class UI_Window_Notifications : UI_Window
{
	public enum OpenTarget
	{
		Default,
		Events,
		Quests,
		Notifications
	}

	private const string LAST_TAB_SELECTED_KEY = "UI_Window_Notifications_LastTabSelected";

	private int? _lastTabSelected;

	[SerializeField]
	private UI_TabGroup _tabGroup;

	private int LastTabSelected
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static void OpenWindow(OpenTarget inOpenTarget = OpenTarget.Default)
	{
	}

	public static void QueueWindow(OpenTarget inOpenTarget = OpenTarget.Default)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(OpenTarget inOpenTarget)
	{
	}

	protected override void OnOpen(bool inAnimate)
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnTabSelected(int inTabIndex)
	{
	}
}
