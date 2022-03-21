using System;
using System.Runtime.InteropServices;

public class Notification
{
	public NotificationGroup notificationGroup;

	public NotificationType notificationType;

	public bool isLogged;

	public BaseDef baseDef;

	public DateTime timeStamp;

	public string messageText;

	public UserInfo userInfo;

	public string imageDefId;

	public int? quantity;

	private bool _isUnread;

	private bool _messageSanitized;

	public bool? _hasImage;

	public bool? _hasRawImage;

	public string Text
	{
		get
		{
			return null;
		}
	}

	public bool IsUnread
	{
		get
		{
			return default(bool);
		}
	}

	public bool HasImage
	{
		get
		{
			return default(bool);
		}
	}

	public bool HasRawImage
	{
		get
		{
			return default(bool);
		}
	}

	public Notification(BaseDef inBaseDef)
	{
	}

	public Notification([Optional] string inMessageText, [Optional] string inImageDefId)
	{
	}

	public void MarkAsRead()
	{
	}

	public string GetTimeStampUIString()
	{
		return null;
	}
}
