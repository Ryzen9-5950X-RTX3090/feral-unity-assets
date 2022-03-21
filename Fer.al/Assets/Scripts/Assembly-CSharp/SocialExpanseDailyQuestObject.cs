using UnityEngine;

public class SocialExpanseDailyQuestObject : MonoBehaviour
{
	[Tooltip("GameObjects to be active when the quest is incomplete and disabled when the quest is complete")]
	public GameObject[] questIncompleteObjects;

	[Tooltip("GameObjects to be active when the quest is complete and disabled when the quest is incomplete")]
	public GameObject[] questCompletObjects;

	public GameObject serverDisableIfComplete;

	private bool _ranAtStartup;

	public void InitDailyQuest(long inCoolDownTime)
	{
	}
}
