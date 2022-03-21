using UnityEngine;

public class CheckQuestCompletion : MonoBehaviour
{
	[Space]
	[Space(6f)]
	[RootSelectorCompact("Quest Chart ID", "QuestChartData", null, false, false)]
	public string questId;

	public bool activeWhenQuestComplete;

	public bool activeWhenQuestIncomplete;

	private void Start()
	{
	}
}
