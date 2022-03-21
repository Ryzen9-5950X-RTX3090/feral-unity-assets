using System.Runtime.CompilerServices;

public class CasualGamePausedMessage : Message
{
	public bool Paused
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

	public CasualGamePausedMessage(bool inPaused)
	{
	}
}
