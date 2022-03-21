using System.Runtime.CompilerServices;

public class CodeBreakerGamePausedMessage : Message
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

	public CodeBreakerGamePausedMessage(bool inPaused)
	{
	}
}
