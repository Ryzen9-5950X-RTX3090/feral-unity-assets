using System.Collections.Generic;

[ChartComponent("Season Pass Challenge")]
public class SeasonPassChallengeDefComponent : DefComponent
{
	[ChartInt]
	public int auraPointsReward;

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
