using System.Runtime.CompilerServices;

public class RequestQuestOpenSuccessMessage : Message
{
	public QuestDefComponent QuestDef
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

	public RequestQuestOpenSuccessMessage(QuestDefComponent inQuestDef)
	{
	}
}
