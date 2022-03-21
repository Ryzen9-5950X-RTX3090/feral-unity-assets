using System.Runtime.CompilerServices;
using Server;

public class RoomJoinMessage : ServerMessage
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

	public string RoomDefId
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

	public RoomType RoomType
	{
		[CompilerGenerated]
		get
		{
			return default(RoomType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int IssRoomId
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

	public string SanctuaryJoinOwnerUUID
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

	public string GoToPlayerUUID
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

	public string NewNodeIpOnNodeHop
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

	public LanguageId LanguageOnLanguageChange
	{
		[CompilerGenerated]
		get
		{
			return default(LanguageId);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string RoomConversationId
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

	public RoomJoinMessage(XtReader data)
	{
	}
}
