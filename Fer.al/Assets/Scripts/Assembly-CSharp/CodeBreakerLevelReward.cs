using System;

[Serializable]
public class CodeBreakerLevelReward
{
	[ChartInt]
	public int levelIndex;

	[ChartBool]
	public bool isRange;

	[ChartInt]
	public int endLevelIndex;

	[ChartInt]
	public int oneStarRewardIndex;

	[ChartInt]
	public int twoStarRewardIndex;

	[ChartInt]
	public int threeStarRewardIndex;

	[ChartInt]
	public int threeStarReplayRewardIndex;
}
