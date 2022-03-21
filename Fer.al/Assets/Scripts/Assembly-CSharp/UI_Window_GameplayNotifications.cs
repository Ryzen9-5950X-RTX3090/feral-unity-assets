using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_GameplayNotifications : UI_Window
{
	[SerializeField]
	private int _maxShownNotifications;

	[SerializeField]
	private float _notificationDisplayTime;

	[SerializeField]
	private UI_GameplayNotificationItem _notificationAlertItemPrefab;

	[SerializeField]
	private LazyLayoutGroup _layout;

	private List<Notification> _notificationQueue;

	private List<UI_GameplayNotificationItem> _shownNotifications;

	private Dictionary<UI_GameplayNotificationItem, float> _notificationTimers;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
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

	public void AddNotification(Notification inNotification)
	{
	}

	private void ShowNotification(Notification inNotification)
	{
	}

	private void ShowNextNotification()
	{
	}

	private void RemoveNotification(UI_GameplayNotificationItem inNotification)
	{
	}

	public override void MUpdate()
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
