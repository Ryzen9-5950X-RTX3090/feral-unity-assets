using System.Runtime.CompilerServices;
using Server;

[RoutedMessage(XtCmd.RelationshipFollowerJumpToRoom, QueueMessageMode.Never)]
public class RelationshipFollowerJumpToRoomResponse : ServerMessage
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

	public int roomIssId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string otherNode
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

	public RelationshipFollowerJumpToRoomResponse(INetMessageReader data)
	{
	}
}
