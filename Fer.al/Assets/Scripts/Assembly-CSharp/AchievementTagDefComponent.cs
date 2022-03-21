using System.Collections.Generic;

[ChartComponent("Achievement Tag")]
public class AchievementTagDefComponent : DefComponent
{
	[ChartList]
	public List<AchievementAction> actions;

	[ChartStringEnum(typeof(AchievementOperation))]
	public string operation;

	[ChartList]
	[ChartDef("CraftableItem", new string[] { })]
	public List<string> defs;

	[ChartList]
	[ChartStringEnum(typeof(AchievementTag))]
	public List<string> tags;
}
