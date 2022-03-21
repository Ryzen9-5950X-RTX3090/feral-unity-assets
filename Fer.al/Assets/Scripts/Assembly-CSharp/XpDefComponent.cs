using System.Collections.Generic;

[ChartComponent("XP")]
public class XpDefComponent : DefComponent
{
	[ChartInt]
	public int xpRewarded;

	[ChartBool]
	public bool multiply;

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

	[ChartClass]
	public ChartDuration repeatWindow;

	[ChartList]
	[ChartStringEnum(typeof(UniqueType))]
	public List<string> uniqueType;
}
