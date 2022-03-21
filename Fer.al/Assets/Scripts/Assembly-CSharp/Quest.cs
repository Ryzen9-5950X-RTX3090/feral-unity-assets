using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Quest
{
	private QuestDefComponent _questDef;

	private SocialExpanseDefComponent _socialExpanseDef;

	private TutorialQuestDefComponent _tutorialQuestDef;

	private QueensQuestEventDefComponent _queensQuestEventDef;

	public QuestObjective _currentObjective;

	private bool _isPrimary;

	public QuestDefComponent QuestDef
	{
		get
		{
			return null;
		}
	}

	public SocialExpanseDefComponent SocialExpanseDef
	{
		get
		{
			return null;
		}
	}

	public TutorialQuestDefComponent TutorialQuestDef
	{
		get
		{
			return null;
		}
	}

	public QueensQuestEventDefComponent QueensQuestEventDef
	{
		get
		{
			return null;
		}
	}

	public QuestObjective CurrentObjective
	{
		get
		{
			return null;
		}
	}

	public bool IsCompleted
	{
		get
		{
			return default(bool);
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

	public bool IsChallenge
	{
		get
		{
			return default(bool);
		}
	}

	public void SetCurrentObjective(QuestDefObjective inCurrentObjectiveDef, [Optional] List<ValueTuple<int, int>> inTaskStates)
	{
	}

	public void UpdateTask(int taskIndex, int inProgress)
	{
	}

	public Quest(QuestDefObjective inCurrentObjectiveInfo, bool inIsPrimary, [Optional] List<ValueTuple<int, int>> inTaskStates, [Optional] QueensQuestEventDefComponent inQuestDef)
	{
	}

	public Quest(QuestDefObjective inCurrentObjectiveInfo, bool inIsPrimary, [Optional] List<ValueTuple<int, int>> inTaskStates, [Optional] TutorialQuestDefComponent inQuestDef)
	{
	}

	public Quest(QuestDefObjective inCurrentObjectiveInfo, bool inIsPrimary, [Optional] List<ValueTuple<int, int>> inTaskStates, [Optional] QuestDefComponent inQuestDef)
	{
	}

	public Quest(QuestDefObjective inCurrentObjectiveInfo, bool inIsPrimary, [Optional] List<ValueTuple<int, int>> inTaskStates, [Optional] SocialExpanseDefComponent inSocialExpanseDef)
	{
	}

	private Quest(QuestDefObjective inCurrentObjectiveInfo, bool inIsPrimary, [Optional] List<ValueTuple<int, int>> inTaskStates)
	{
	}
}
