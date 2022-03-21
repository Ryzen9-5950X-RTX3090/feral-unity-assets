using System.Runtime.CompilerServices;
using Server;

public class RoomJoinTutorialMessage : ServerMessage
{
	public bool Success
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

	public RoomJoinTutorialMessage(INetMessageReader data)
	{
	}
}
