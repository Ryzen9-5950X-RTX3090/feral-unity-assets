using System;

[Serializable]
public class CalendarChartRef
{
	[RootSelector("CalendarChartDefId", "CalendarChartData", false, false)]
	public string defId;

	private BaseDef _baseDef;

	private AvailabilityDefComponent _availabilityDefComponent;

	public BaseDef baseDef
	{
		get
		{
			return null;
		}
	}

	public AvailabilityDefComponent availabilityDefComponent
	{
		get
		{
			return null;
		}
	}
}
