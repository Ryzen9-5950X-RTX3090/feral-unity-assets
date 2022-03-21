using System.Collections.Generic;

[ChartComponent("Bundles")]
public class BundleIDDefComponents : DefComponent
{
	[ChartList]
	[ChartBundle]
	public List<ChartBundle> bundles;
}
