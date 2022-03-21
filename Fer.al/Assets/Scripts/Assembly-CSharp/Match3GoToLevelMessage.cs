using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Match3GoToLevelMessage : CasualGameCommand
{
	public int Level
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

	public Match3GoToLevelMessage(XtReader data)
	{
	}
}
