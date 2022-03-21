using System;
using System.Collections.Generic;

[Serializable]
[ChartComponent("Builders Folly Game Data")]
public class BuildersFollyDefComponent : DefComponent
{
	public string levelScoresUserVarDefId;

	public string expertLevelScoresUserVarDefId;

	[ChartClass]
	public BuildersFollyGoal tutorialLevelGoal_1;

	[ChartClass]
	public BuildersFollyGoal tutorialLevelGoal_2;

	[ChartList]
	public List<BuildersFollyLevelGoals> levelGoals;

	[ChartList]
	public List<BuildersFollyLevelGoals> expertLevelGoals;
}
