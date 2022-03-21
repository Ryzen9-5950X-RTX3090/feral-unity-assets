[ChartComponent("Availability")]
public class AvailabilityDefComponent : DefComponent
{
	public ChartDef dateOverrideRef;

	[ChartDate]
	public ChartDate chartDateAvailability;

	[ChartSearch("Available Now")]
	public static bool AvailabileNowSearch(DefComponent inDefComponent, string inSearch)
	{
		return default(bool);
	}

	[ChartSearch("Available Date")]
	public static bool AvailabilitySearch(DefComponent inDefComponent, string inSearch)
	{
		return default(bool);
	}
}
