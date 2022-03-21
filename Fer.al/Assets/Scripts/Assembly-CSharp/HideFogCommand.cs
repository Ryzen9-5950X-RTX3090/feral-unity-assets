using System.Runtime.CompilerServices;
using UnityEngine;

public class HideFogCommand : Message
{
	public static int RequestCount
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

	public static bool RestoreState
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

	public bool Hidden
	{
		get
		{
			return default(bool);
		}
	}

	public HideFogCommand(bool inHide)
	{
	}

	[RuntimeInitializeOnLoadMethod]
	[CoreResetTarget]
	public static void Reset()
	{
	}
}
