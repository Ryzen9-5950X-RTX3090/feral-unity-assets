using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_ObjectiveItem : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private Transform _taskItemParent;

	[SerializeField]
	private UI_TaskItem _taskItemPrefab;

	[SerializeField]
	private GameObject _noTasksGroup;

	private Quest _quest;

	private QuestObjective _objective;

	private List<UI_TaskItem> _taskItems;

	private bool _isUnread;

	public CanvasGroup CanvasGroup
	{
		get
		{
			return null;
		}
	}

	public Quest Quest
	{
		get
		{
			return null;
		}
	}

	public bool IsUnread
	{
		get
		{
			return default(bool);
		}
	}

	public void Setup(Quest inQuest)
	{
	}

	public void MarkAsRead()
	{
	}

	private void SpawnTaskItems()
	{
	}

	private void RefreshText()
	{
	}
}
