using TMPro;
using UnityEngine;

public class UI_UnreadNotificationCount : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _unreadCountText;

	[SerializeField]
	private bool _includeSystemNotifications;

	[SerializeField]
	private bool _includeLinearQuestAlerts;

	private int _unreadCount;

	private void Start()
	{
	}

	private void OnNotificationsRead(NotificationsReadMessage inMessage)
	{
	}

	private void OnNotificationSent(NotificationSentMessage inMessage)
	{
	}

	private void OnLinearQuestAlertsUpdated(LinearQuestAlertsUpdatedMessage inMessage)
	{
	}

	private void OnDestroy()
	{
	}

	private void RefreshCount()
	{
	}

	private void RefreshText()
	{
	}
}
