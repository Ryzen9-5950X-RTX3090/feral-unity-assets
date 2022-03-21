using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class RunesGameStartMessage : CasualGameCommand
{
	public List<RuneGroupType> runeGroupTypes
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

	public List<List<RuneType>> runeGroups
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

	public RunesGameStartMessage(XtReader data)
	{
	}
}
