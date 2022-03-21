using System;
using UnityEngine;

[Serializable]
public class QuestItemComponent : ItemComponent
{
	[SerializeField]
	private bool open;

	[SerializeField]
	private QuestSummary best;

	[SerializeField]
	private int completions;

	private TimestampItemComponent _timestampItemComponent;

	public QuestDefComponent QuestDef
	{
		get
		{
			return null;
		}
	}

	public string Title
	{
		get
		{
			return null;
		}
	}

	public string Description
	{
		get
		{
			return null;
		}
	}

	public ImageDefComponent ImageDef
	{
		get
		{
			return null;
		}
	}

	public string GiverName
	{
		get
		{
			return null;
		}
	}

	public string Location
	{
		get
		{
			return null;
		}
	}

	public ImageDefComponent ChallengeBannerImageDef
	{
		get
		{
			return null;
		}
	}

	public bool IsChallenge
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsOpen
	{
		get
		{
			return default(bool);
		}
	}

	public DateTime TimeOpened
	{
		get
		{
			return default(DateTime);
		}
	}

	public QuestSummary BestRunSummary
	{
		get
		{
			return null;
		}
	}

	public bool IsActive
	{
		get
		{
			return default(bool);
		}
	}

	public int CompletionCount
	{
		get
		{
			return default(int);
		}
	}

	public override void OnLoaded()
	{
	}

	public QuestItemComponent Setup(QuestDefComponent inQuestDef)
	{
		return null;
	}

	public void CompleteQuest(QuestSummary inQuestSummary)
	{
	}

	public void ReopenQuest()
	{
	}
}
