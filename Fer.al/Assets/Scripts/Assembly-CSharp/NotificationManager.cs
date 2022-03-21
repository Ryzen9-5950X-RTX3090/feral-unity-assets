using System.Collections.Generic;

public class NotificationManager : SingletonManagerBase<NotificationManager>
{
	public List<Notification> loggedNotifications;

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	public void AddGameplayNotification(Notification inNotification)
	{
	}

	public void AddSystemNotification(Notification inNotification)
	{
	}

	public void AddCriticalNotification(Notification inNotification)
	{
	}

	public void AddNotification(Notification inNotification)
	{
	}

	public int GetUnreadNotificationCount()
	{
		return default(int);
	}

	public void MarkAllAsRead()
	{
	}

	public void AddLevelUpNotification(XPUpdateServerMessage.CompletedLevel inCompletedLevel, IPlayerLevel inCurLevel)
	{
	}
}
