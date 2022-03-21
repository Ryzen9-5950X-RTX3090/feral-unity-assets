using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class TestLinearQuestListData : ILinearQuestListData
{
	public List<ILinearQuestData> Quests
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

	public ILinearQuestData CurrentAvailableQuest
	{
		get
		{
			return null;
		}
	}
}
