using System;
using System.Collections.Generic;

[Serializable]
[ChartComponent("Code Breaker Game Data")]
public class CodeBreakerDefComponent : DefComponent
{
	[ChartList]
	public List<CodeBreakerLevelReward> levelRewards;

	public string scoreUserVarDefId;

	public string levelsUnlockedUserVarDefId;

	[ChartInt]
	public int firstGuessBonus;

	[ChartInt]
	public int lastIngredientBonus;

	[ChartClass]
	public CodeBreakerLevel tutorialLevel;

	[ChartList]
	public List<CodeBreakerLevel> levels;
}
