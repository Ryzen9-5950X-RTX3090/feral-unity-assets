using System.Collections.Generic;

[ChartComponent("Dialog")]
public class DialogDefComponent : DefComponent
{
	[ChartBundle]
	public ChartBundle bundle;

	[ChartDate]
	public ChartDate availability;

	[ChartList]
	[ChartString]
	public List<string> calendarRefs;

	public string BundleID
	{
		get
		{
			return null;
		}
	}
}
