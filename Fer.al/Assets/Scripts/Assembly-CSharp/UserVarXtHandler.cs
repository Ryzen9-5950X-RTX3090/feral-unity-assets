using System.Collections.Generic;
using Server;
using WW.Debug;

[MessageRouteHandler]
public static class UserVarXtHandler
{
	private static CachedUserVar availabilityBypassUserVar;

	[DebugField("Bypass Availability", "Availability", false, true)]
	public static bool IsAvailabilityBypassed
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	[DebugButton("Reset Closed Beta Gift Var", "Availability", true, true)]
	public static void ResetClosedBetaGiftVar()
	{
	}

	[MessageSender(XtCmd.UserVarSet, false)]
	public static void RequestUserVarSet(string defId, long value, int value2, int index)
	{
	}

	[MessageSender(XtCmd.UserVarSetBatch, false)]
	public static void RequestUserVarSetBatch(string defId, List<UserVarSetOperation> inSetOperations)
	{
	}

	[MessageRoute(XtCmd.UserVarSet, QueueMessageMode.Never)]
	private static void HandleUserVarSet(UserVarSetMessage message)
	{
	}

	[MessageRoute(XtCmd.UserVarSetBatch, QueueMessageMode.Never)]
	private static void HandleUserVarSetBatch(UserVarSetBatchMessage message)
	{
	}
}
