using System.Runtime.CompilerServices;
using Server;

public class RelationshipFollowingFindPlayerUUIDResponse : ServerMessage
{
	public bool success
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

	public string foundUUID
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

	public RelationshipFollowingFindPlayerUUIDResponse(XtReader data)
	{
	}
}
