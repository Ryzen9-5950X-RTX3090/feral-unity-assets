using System.Runtime.CompilerServices;

public class CodeAttemptMessage : Message
{
	public CodeAttempt Attempt
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

	public CodeAttemptMessage(CodeAttempt inAttempt)
	{
	}
}
