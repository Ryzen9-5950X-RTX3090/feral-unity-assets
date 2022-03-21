using System;

[Serializable]
[ChartComponent("Notification")]
public class NotificationDefComponent : DefComponent
{
	public string localizedMessageRefID;

	public string localizedButtonRefID;

	public int importance;

	public string calendarRefID;

	public int hourOfDay;

	public string soundName;
}
