using System.Runtime.CompilerServices;

public class LinearQuestData : ILinearQuestData
{
	private ILinearQuestListData _listData;

	private SocialExpanseDefComponent _def;

	public string QuestDefId
	{
		get
		{
			return null;
		}
	}

	public string QuestName
	{
		get
		{
			return null;
		}
	}

	public string QuestGiverName
	{
		get
		{
			return null;
		}
	}

	public string QuestDescription
	{
		get
		{
			return null;
		}
	}

	public string QuestGiverIconDefId
	{
		get
		{
			return null;
		}
	}

	public SocialExpanseArea QuestSocialExpanseArea
	{
		get
		{
			return default(SocialExpanseArea);
		}
	}

	public string QuestIconDefId
	{
		get
		{
			return null;
		}
	}

	public bool IsUnlocked
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsCompleted
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public LinearQuestData(ILinearQuestListData listData, SocialExpanseDefComponent def, bool isCompleted)
	{
	}

	public void MarkAsComplete(bool isComplete)
	{
	}
}
