using System;

[Serializable]
public class QuestSummary
{
	public enum TallyType
	{
		SideQuests,
		Cinders,
		Secrets,
		Treasures,
		Puzzles
	}

	[Serializable]
	public class SummaryTallies
	{
		public SummaryTally sideQuests;

		public SummaryTally cinders;

		public SummaryTally secrets;

		public SummaryTally treasures;

		public SummaryTally puzzles;
	}

	[Serializable]
	public class SummaryTally
	{
		public int current;

		public int targetMax;
	}

	public SummaryTallies summaryTallies;

	public float GetNormalizedProgress(bool inQuestIsComplete = true)
	{
		return default(float);
	}

	public void SetTallyValue(TallyType inTallyType, int inValue)
	{
	}
}
