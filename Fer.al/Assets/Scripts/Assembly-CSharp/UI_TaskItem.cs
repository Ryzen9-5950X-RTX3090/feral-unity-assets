using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_TaskItem : MonoBehaviour
{
	[SerializeField]
	private GameObject _isUnreadGameObject;

	[SerializeField]
	private FeralButton _isCompleteToggle;

	[SerializeField]
	private WWTextMeshProUGUI _taskDescription;

	[SerializeField]
	private WWTextMeshProUGUI _progressText;

	[SerializeField]
	private WWImage _iconImage;

	[SerializeField]
	private Color _taskCompleteColor;

	private QuestTask _task;

	public void Setup(QuestTask inTask, bool inIsFinalObjective)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshIsCompleted()
	{
	}

	private void RefreshIsUnread()
	{
	}
}
