using System.Collections.Generic;

[ChartComponent("Sanctuary Model List")]
public class SanctuaryModelListDefComponent : DefComponent
{
	[ChartList]
	public List<ChartDef> modelList;
}
