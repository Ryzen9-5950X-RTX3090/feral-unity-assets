using System;
using System.Collections.Generic;

[Serializable]
public class CodeBreakerLevel
{
	[NameIndexer("Level", false)]
	public string name;

	[ChartInt]
	public int codeLength;

	[EnumFlag]
	[ChartEnumFlag]
	public CodeColor colors;

	[ChartBool]
	public bool allowRepeatColors;

	[ChartBool]
	public bool allowEmpty;

	[ChartInt]
	public int tryCount;

	[ChartInt]
	public int startingIngredientCount;

	[ChartInt]
	public int scorePerIngredient;

	[ChartList]
	public List<TimerScore> timerScoreThresholds;

	[ChartInt]
	public int oneStarScore;

	[ChartInt]
	public int twoStarScore;

	[ChartInt]
	public int threeStarScore;

	public int GetIngredientsLeftScore(int inIngredientsLeft)
	{
		return default(int);
	}

	public int GetTimeBonusScore(int inSecondsToComplete)
	{
		return default(int);
	}

	public int GetStarCount(long inScore)
	{
		return default(int);
	}
}
