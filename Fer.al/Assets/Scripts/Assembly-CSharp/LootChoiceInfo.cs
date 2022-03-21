using System;

[Serializable]
public class LootChoiceInfo
{
	[ChartInt]
	public int weight;

	[ChartDef("Loot", new string[] { })]
	public string lootTableDefID;

	[ChartDef("CraftableItem", new string[] { })]
	public string itemDefID;

	[ChartInt]
	public int minCount;

	[ChartInt]
	public int maxCount;
}
