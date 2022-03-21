using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Match3GameStartMessage : CasualGameCommand
{
	public string GameBoardId
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

	public int GameBoardChecksum
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

	public List<Match3LevelObjectiveTrackingInfo> trackedObjectives
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

	public Match3GameStartMessage(XtReader data)
	{
	}
}
