using System.Runtime.CompilerServices;
using Server;

[RoutedMessage(XtCmd.RelationshipOnlineStatus, QueueMessageMode.Never)]
public class OnlineStatusResponse : ServerMessage, ITaggedMessage
{
	public string userUUID
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

	public OnlineStatus onlineStatus
	{
		[CompilerGenerated]
		get
		{
			return default(OnlineStatus);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string GetTag()
	{
		return null;
	}

	public OnlineStatusResponse(INetMessageReader data)
	{
	}
}
