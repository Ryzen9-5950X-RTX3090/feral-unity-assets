using System.Runtime.CompilerServices;
using Server;

public class TutorialCompleteResponse : ServerMessage, ISuccessMessage
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

	public string AvatarLookItemId
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

	public TutorialCompleteResponse(INetMessageReader data)
	{
	}
}
