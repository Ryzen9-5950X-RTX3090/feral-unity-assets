using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class RunesSpawnRuneGroupMessage : CasualGameCommand
{
	public int GroupIndex
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

	public RuneGroupType GroupType
	{
		[CompilerGenerated]
		get
		{
			return default(RuneGroupType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<RuneType> Group
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

	public RunesSpawnRuneGroupMessage(XtReader data)
	{
	}
}
