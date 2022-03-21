using System;

[Serializable]
public class AchievementAction
{
	[ChartStringEnum(typeof(AchievementActionType))]
	public string action;

	[ChartStringEnum(typeof(AchievementComparison))]
	public string comparison;

	[ChartInt]
	public int value;
}
