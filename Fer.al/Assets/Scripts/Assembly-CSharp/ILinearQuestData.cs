public interface ILinearQuestData
{
	string QuestDefId { get; }

	string QuestName { get; }

	string QuestGiverName { get; }

	string QuestDescription { get; }

	string QuestGiverIconDefId { get; }

	string QuestIconDefId { get; }

	bool IsUnlocked { get; }

	bool IsCompleted { get; }

	SocialExpanseArea QuestSocialExpanseArea { get; }

	void MarkAsComplete(bool isComplete);
}
