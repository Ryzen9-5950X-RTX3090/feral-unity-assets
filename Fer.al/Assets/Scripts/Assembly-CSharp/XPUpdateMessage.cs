using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class XPUpdateMessage : TaggedMessage
{
	public string UUID
	{
		get
		{
			return null;
		}
	}

	public int TotalXP
	{
		get
		{
			return default(int);
		}
	}

	public int XPGained
	{
		get
		{
			return default(int);
		}
	}

	public IPlayerLevel PrevLevel
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

	public IPlayerLevel CurLevel
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

	public List<XPUpdateServerMessage.CompletedLevel> CompletedLevels
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

	public XPUpdateMessage(string inUUID, IPlayerLevel inPrevLevel, IPlayerLevel inCurLevel, List<XPUpdateServerMessage.CompletedLevel> inCompletedLevels)
	{
	}

	public void Aggregate(XPUpdateMessage inAdditionalMessage)
	{
	}
}
