using System.Runtime.CompilerServices;
using Server;

public class LoginMessage : Message
{
	public bool renameRequired;

	public string renameRequiredKey;

	public LoginStatus Status
	{
		[CompilerGenerated]
		get
		{
			return default(LoginStatus);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public LoginData Data
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

	public LoginMessage(LoginStatus status, LoginData data)
	{
	}

	public LoginMessage(ServerLoginResponse response)
	{
	}
}
