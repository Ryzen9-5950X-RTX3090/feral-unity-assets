using System;
using System.Collections.Generic;

[Serializable]
[ChartComponent("Image")]
public class ImageDefComponent : DefComponent
{
	[ChartBool]
	public bool localize;

	[ChartBool]
	public bool highQualityAndLowQuality;

	[ChartList]
	[ChartString]
	public List<string> bundleIDArray;

	[ChartList]
	[ChartDef("Calendar", new string[] { })]
	public ChartDefList calendarRefArray;

	public bool isAvailable
	{
		get
		{
			return default(bool);
		}
	}
}
