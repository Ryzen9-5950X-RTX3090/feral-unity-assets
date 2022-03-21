using System.Collections.Generic;

[ChartComponent("Runes Game Data")]
public class RunesDataDefComponent : DefComponent
{
	[ChartInt]
	public int gridSize;

	[ChartList]
	public List<RunesLevel> levelRewards;

	[ChartInt]
	public int powerUpMeterFillRateLevel1;

	[ChartInt]
	public int powerUpMeterFillRateLevel2;

	public string scoreUserVarDefId;
}
