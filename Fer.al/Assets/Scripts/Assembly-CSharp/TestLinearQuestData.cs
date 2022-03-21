using System.Runtime.CompilerServices;

public class TestLinearQuestData : ILinearQuestData
{
	private ILinearQuestListData _questList;

	public string QuestDefId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string QuestName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string QuestGiverName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string QuestDescription
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string QuestGiverIconDefId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string QuestIconDefId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
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

	public SocialExpanseArea QuestSocialExpanseArea
	{
		[CompilerGenerated]
		get
		{
			return default(SocialExpanseArea);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public TestLinearQuestData(ILinearQuestListData questList, string questName, string npcDefId, string questDescription, string questIconDefId, bool isCompleted)
	{
	}

	public void MarkAsComplete(bool inIsComplete)
	{
	}
}
