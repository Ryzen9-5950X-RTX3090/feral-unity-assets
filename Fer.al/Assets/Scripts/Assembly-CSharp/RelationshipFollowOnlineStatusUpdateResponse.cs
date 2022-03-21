using System.Runtime.CompilerServices;
using Server;

public class RelationshipFollowOnlineStatusUpdateResponse : ServerMessage
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

	public RelationshipFollowOnlineStatusUpdateResponse(XtReader data)
	{
	}
}
