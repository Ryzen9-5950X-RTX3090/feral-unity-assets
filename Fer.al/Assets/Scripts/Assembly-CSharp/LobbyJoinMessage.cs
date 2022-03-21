using System.Runtime.CompilerServices;
using Server;

public class LobbyJoinMessage : ServerMessage
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

	public LobbyJoinMessage(XtReader data)
	{
	}
}
