using System;
using System.Collections.Generic;

[ChartComponent("Loot")]
public class LootDefComponent : DefComponent
{
	[ChartEnum]
	public LootOperation operationType;

	[ChartList]
	public List<LootChoiceInfo> choices;

	protected override void LoadEntry()
	{
	}

	public ValueTuple<BaseDef, int> GetOnlyLootChoice()
	{
		return default(ValueTuple<BaseDef, int>);
	}
}
