public class OverheadBubbleMessage : Message, ITaggedMessage
{
	public readonly string SubCmd;

	public readonly string UserUUID;

	public readonly string QuestDefId;

	public string GetTag()
	{
		return null;
	}

	public OverheadBubbleMessage(string inSubCmd, string inUserUUID, string inQuestDefId)
	{
	}
}
