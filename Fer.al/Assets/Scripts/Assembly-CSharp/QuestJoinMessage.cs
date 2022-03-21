using System.Runtime.CompilerServices;
using Server;

public class QuestJoinMessage : ServerMessage
{
	public string ErrorMessage
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

	public bool Success
	{
		get
		{
			return default(bool);
		}
	}

	public QuestJoinMessage(XtReader data)
	{
	}
}
