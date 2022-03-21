using UnityEngine;
using UnityEngine.UI;

public class UI_QuestPanel : MonoBehaviour
{
	[SerializeField]
	private FeralButton _completedQuestsButton;

	[SerializeField]
	private CanvasGroup _completedQuestsGroup;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void BtnClicked_ViewCompletedQuests(bool inView)
	{
	}

	private void OnLinearQuestCompleted(LinearQuestCompleteMessage inMessage)
	{
	}

	private void RefreshCompletedQuestsButton()
	{
	}
}
