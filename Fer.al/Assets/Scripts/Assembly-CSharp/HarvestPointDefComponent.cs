using System.Collections.Generic;

[ChartComponent("HarvestPoint")]
public class HarvestPointDefComponent : DefComponent
{
	[ChartList]
	[ChartDef("CraftableItem", new string[] { })]
	public ChartDefList craftableItemRefArray;

	[ChartList]
	[ChartInt]
	public List<int> minimumCraftableItemsPerHarvest;

	[ChartList]
	[ChartInt]
	public List<int> maximumCraftableItemsPerHarvest;

	[ChartList]
	[ChartInt]
	public List<int> percentChance;

	[ChartInt]
	public int harvests;

	private bool Contains(string inCraftableItemDefId, out int IndexOf)
	{
		return default(bool);
	}

	public void GetMinAndMax(string inCraftableItemDefId, out int outMin, out int outMax)
	{
	}

	public void GetMinAndMaxAndPercent(string inCraftableItemDefId, out int outMin, out int outMax, out int outPercent)
	{
	}

	public int GetMinimum(string inCraftableItemDefId)
	{
		return default(int);
	}

	public int GetMaximum(string inCraftableItemDefId)
	{
		return default(int);
	}

	public int GetPercent(string inCraftableItemDefId)
	{
		return default(int);
	}
}
