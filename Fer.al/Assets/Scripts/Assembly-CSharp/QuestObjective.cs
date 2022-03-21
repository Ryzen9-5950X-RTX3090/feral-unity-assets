using System.Collections.Generic;

public class QuestObjective
{
	private QuestDefObjective _objectiveInfo;

	private List<QuestTask> _tasks;

	public QuestDefObjective ObjectiveInfo
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

	public bool IsFinalObjective
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsCompleted
	{
		get
		{
			return default(bool);
		}
	}

	public float NormalizedProgress
	{
		get
		{
			return default(float);
		}
	}

	public List<QuestTask> Tasks
	{
		get
		{
			return null;
		}
	}

	public QuestObjective(QuestDefObjective inObjectiveInfo)
	{
	}
}
