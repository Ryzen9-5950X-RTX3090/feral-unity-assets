using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HideHUDCommand : Message
{
	private static Dictionary<string, int> _hideCountOverrideOffsets;

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

	public static bool Hidden
	{
		get
		{
			return default(bool);
		}
	}

	public static bool IsHidden(string inExclusionKey = "")
	{
		return default(bool);
	}

	public HideHUDCommand(bool inHide)
	{
	}

	public HideHUDCommand(bool inHide, string[] inExclusionKeys)
	{
	}

	[CoreResetTarget]
	[RuntimeInitializeOnLoadMethod]
	public static void Reset()
	{
	}
}
