using System;

[Serializable]
public class Match3AchievementUserVarIndexPair
{
	[ChartEnum]
	public Match3AchievementType achievementType;

	[ChartInt]
	public int userVarIndex;
}
