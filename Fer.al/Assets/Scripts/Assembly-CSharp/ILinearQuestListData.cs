using System.Collections.Generic;

public interface ILinearQuestListData
{
	List<ILinearQuestData> Quests { get; }

	ILinearQuestData CurrentAvailableQuest { get; }
}
