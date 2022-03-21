using System.Collections.Generic;
using DG.DeInspektor.Attributes;
using UnityEngine;

[CreateAssetMenu]
public class Match3LevelData : ScriptableObject
{
	public Match3LevelGrowthRate levelGrowthRate;

	public List<Match3LevelSpecialOrder> specialOrders;

	public List<Match3SpecialOrderCountRangeByLevel> specialOrderCountRanges;

	public bool useDebugSpecialOrders;

	public List<Match3LevelSpecialOrder> debugSpecialOrders;

	public List<Match3SpecialOrderCountRangeByLevel> debugSepcialOrderCountRanges;

	[Space]
	[Space(6f)]
	[EnumList(typeof(SpecialOrderType), 0.35f)]
	public List<Sprite> specialOrderIcons;

	[RootSelectorCompact("Special Order Text", "LocalizationChartData", null, false, false)]
	public List<string> specialOrderText;

	public void Initialize()
	{
	}

	public Match3LevelSpecialOrder GetSpecialOrder(int levelNumber)
	{
		return null;
	}

	public Match3SpecialOrderCountRangeByLevel GetSpecialOrderCountRange(int levelNumber)
	{
		return null;
	}

	[DeMethodButton("Transfer Level Data to Def Component", 0, new object[] { })]
	public void TransferLevelDataToDefComponent()
	{
	}
}
