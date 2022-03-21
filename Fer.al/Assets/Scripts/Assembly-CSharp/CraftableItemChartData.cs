using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class CraftableItemChartData : ChartDataObject<BaseDef, CraftableItemChartData>
{
	protected override BaseDef CreateDef(Dictionary<string, string> inHeaderNameToDataDict)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<GetDefsWithComponent>d__1<>))]
	public static IEnumerable<T> GetDefsWithComponent<T>() where T : DefComponent
	{
		return null;
	}
}
