using System.Collections.Generic;

public class NotificationsClearedMessage : Message
{
	public readonly List<Notification> notifications;

	public NotificationsClearedMessage(List<Notification> inNotifications)
	{
	}
}
