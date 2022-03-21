[ChartComponent("Bundle")]
public class BundleIDDefComponent : DefComponent
{
	[ChartBundle]
	public ChartBundle bundle;

	public string BundleID
	{
		get
		{
			return null;
		}
	}

	protected override void LoadEntry()
	{
	}
}
