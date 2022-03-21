using System.Runtime.CompilerServices;
using UnityEngine;

public class HideNamebarsCommand : Message
{
	public static int HideCount
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

	public bool Hidden
	{
		get
		{
			return default(bool);
		}
	}

	public HideNamebarsCommand(bool inHide)
	{
	}

	[RuntimeInitializeOnLoadMethod]
	[CoreResetTarget]
	public static void Reset()
	{
	}
}
