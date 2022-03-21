using UnityEngine;

[ManagedBehaviourManager("QuestManager")]
public class QuestSummaryConfiguration : ManagedBehaviour
{
	[Space]
	[Space(6f)]
	[RootSelectorCompact("Quest Chart ID", "QuestChartData", null, false, false)]
	public string questChartID;

	public QuestSummary questSummary;

	[ContextMenu("To Json")]
	public string ToChartJson()
	{
		return null;
	}
}
