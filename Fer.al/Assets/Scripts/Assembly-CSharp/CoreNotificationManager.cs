using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CoreNotificationManager : CoreManagerBase<CoreNotificationManager>
{
	public enum NotificationExecuteMode
	{
		Inexact,
		Exact,
		ExactAndAllowWhileIdle
	}

	protected struct AJNotification
	{
		public NotificationDefComponent notificationDef;

		public DateTime fireDate;

		public AJNotification(NotificationDefComponent notificationDef, DateTime fireDate)
		{
		}
	}

	private static Color32 notificationColor;

	private int START_HOUR;

	private int END_HOUR;

	public static void SendNotification(int id, DateTime fireDate, string title, string message, bool sound = true, bool vibrate = true, bool lights = true, string bigIcon = "", NotificationExecuteMode executeMode = NotificationExecuteMode.Inexact)
	{
	}

	public static void SendRepeatingNotification(int id, DateTime fireDate, long timeout, string title, string message, bool sound = true, bool vibrate = true, bool lights = true, string bigIcon = "")
	{
	}

	public static void CancelNotification(object identifier)
	{
	}

	public static void CancelAllNotifications()
	{
	}

	public override void Init()
	{
	}

	public override void MUpdate()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	public static void RegisterForNotifications()
	{
	}

	[IteratorStateMachine(typeof(<WaitForDeviceToken>d__13))]
	private static IEnumerator WaitForDeviceToken()
	{
		return null;
	}

	protected void ScheduleAllLocalNotifications(List<AJNotification> notificationsToSchedule)
	{
	}

	private DateTime DelayNotification(DateTime inFireDate)
	{
		return default(DateTime);
	}

	public virtual void ClearAndScheduleAllLocalNotifications()
	{
	}

	protected DateTime? GetFireDate(NotificationDefComponent notificationDef, DateTime nowUtc, long currTimeTicks)
	{
		return null;
	}

	protected void ClearAllLocalNotifications()
	{
	}
}
