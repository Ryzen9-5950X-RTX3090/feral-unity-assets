public class QuestTask
{
	private QuestDefTask _taskInfo;

	private int _currentProgress;

	private bool _isUnread;

	public QuestDefTask TaskInfo
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

	public int CurrentProgress
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int TargetProgress
	{
		get
		{
			return default(int);
		}
	}

	public float NormalizedProgress
	{
		get
		{
			return default(float);
		}
	}

	public bool ShowProgressText
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

	public bool IsUnread
	{
		get
		{
			return default(bool);
		}
	}

	public QuestTask(QuestDefTask inTaskDef)
	{
	}

	public void MarkAsRead()
	{
	}
}
