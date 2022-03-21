using System.Runtime.CompilerServices;
using Server;

public class UserVarSetMessage : ServerMessage
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

	public string userVarDefId
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

	public long newValue
	{
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int index
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

	public UserVarSetMessage(XtReader data)
	{
	}
}
