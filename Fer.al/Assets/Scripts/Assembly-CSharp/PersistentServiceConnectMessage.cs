using System.Runtime.CompilerServices;

public abstract class PersistentServiceConnectMessage : Message
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

	public string Message
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

	public PersistentServiceConnectMessage(bool success, string message = "")
	{
	}
}
