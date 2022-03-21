using System.Collections.Generic;

public class WorldSurfaceChartData : ChartDataObject<BaseDef, WorldSurfaceChartData>
{
	private List<Dictionary<string, WorldSurfaceDefComponent>> _matchStringToSurfaceDefComponentDicts;

	public WorldSurfaceDefComponent GetMatchingSurfaceDef(string inMatchString, WorldSurfaceType inSurfaceType)
	{
		return null;
	}

	private WorldSurfaceDefComponent GetWorldSurfaceDefComponent(string inMatchString, out string outMatchString, WorldSurfaceType inSurfaceType)
	{
		return null;
	}
}
