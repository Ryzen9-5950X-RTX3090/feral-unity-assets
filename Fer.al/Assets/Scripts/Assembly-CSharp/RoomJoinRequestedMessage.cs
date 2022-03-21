using System.Runtime.CompilerServices;

public class RoomJoinRequestedMessage : Message
{
	public string RoomName
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

	public bool IsNodeHop
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

	public RoomJoinRequestedMessage(string inRoomName, bool inIsNodeHop)
	{
	}
}
