using System.Collections.Generic;

[ChartComponent("QGE Chest")]
public class QGEChestDefComponent : DefComponent
{
	[ChartList]
	public List<QGEChestSettings.ChestLevel> levels;

	[ChartDef("Loot", new string[] { })]
	public string rewardDefId;
}
