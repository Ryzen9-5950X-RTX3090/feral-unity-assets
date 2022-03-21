using System;

[Serializable]
public class RunesLevel
{
	[ChartInt]
	public int levelThreshold;

	[ChartDef("Loot", new string[] { })]
	public string flameLootDefId;

	[ChartDef("Loot", new string[] { })]
	public string floraLootDefId;

	[ChartDef("Loot", new string[] { })]
	public string miasmaLootDefId;
}
