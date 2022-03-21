using UnityEngine;

public class SimpleQuestReset : MonoBehaviour
{
	[SerializeField]
	[RootSelector("Quest", "QuestChartData", false, false)]
	private string _questDefId;

	public void Reset()
	{
	}
}
