using System;

[Serializable]
public class Match3LevelReward
{
	[ChartInt]
	public int levelIndex;

	[ChartBool]
	public bool isRange;

	[ChartInt]
	public int endLevelIndex;

	[ChartBool]
	public bool isEndLevelInfinite;

	[ChartInt]
	public int rewardIndex;
}
