using System;
using System.Collections.Generic;

[Serializable]
[ChartComponent("Match 3 Game Data")]
public class Match3DefComponent : DefComponent
{
	[ChartList]
	public List<Match3LevelReward> levelRewards;

	[ChartList]
	public List<Match3AchievementPuzzle> achievementPuzzles;

	[ChartInt]
	public int gridSizeRow;

	[ChartInt]
	public int gridSizeCol;

	[ChartInt]
	public int powerupIncrement;

	[ChartList]
	public List<BoosterShapeDataForDef> boosterShapes;

	[ChartClass]
	public Match3LevelGrowthRate levelGrowthRate;

	[ChartList]
	public List<Match3LevelSpecialOrder> specialOrders;

	[ChartList]
	public List<Match3SpecialOrderCountRangeByLevel> specialOrderCountRanges;

	public string persistentAchievementDataUserVarDefId;

	public string puzzleRedemptionStatusUserVarDefId;

	public string puzzlePieceRedemptionStatusUserVarDefId;

	public string savedGameUserVarDefId;

	[ChartList]
	public List<Match3AchievementUserVarIndexPair> achievementToUserVarIndexList;
}
