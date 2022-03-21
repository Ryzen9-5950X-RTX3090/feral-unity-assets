using System;

[Serializable]
public class GlobalChartRef
{
	[RootSelector("GlobalChartDefId", "GlobalChartData", false, false)]
	public string defId;

	private GlobalDefComponent _globalDef;

	public GlobalDefComponent globalDef
	{
		get
		{
			return null;
		}
	}
}
