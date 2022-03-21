using Server;
using WW.Debug;

[MessageRouteHandler]
public static class MinigameXtHandler
{
	public enum MinigamePrizeOperation
	{
		SelectAndRedeem,
		Select,
		Redeem
	}

	[DebugButton("Join", "Minigame", true, false)]
	public static void DebugJoinMinigame(string inDefId)
	{
	}

	[MessageSender(XtCmd.MinigameJoin, false)]
	public static void RequestJoin(string defId)
	{
	}

	public static void RequestMinigamePrize(string defId, int stage, MinigamePrizeOperation op, int prizeIndex1 = 0, int prizeIndex2 = 0)
	{
	}

	public static void RequestMinigameProgress(string inMinigameDefId, int inLevelProgress, int inTotalScore, int inDeltaScore)
	{
	}

	public static void SendMessage(string[] inArgs)
	{
	}

	[MessageRoute(XtCmd.MinigamePrize, QueueMessageMode.Never)]
	private static void HandleMinigamePrizeMessage(MinigamePrizeMessage msg)
	{
	}

	[MessageRoute(XtCmd.MinigameMessage, QueueMessageMode.Never)]
	public static void HandleMMMessage(MinigameMessageResponseMessage msg)
	{
	}

	[MessageRoute(XtCmd.MinigameJoin, QueueMessageMode.Never)]
	public static void HandleMinigameJoinMessage(MinigameJoinResponseMessage msg)
	{
	}

	[MessageRoute(XtCmd.MinigameStart, QueueMessageMode.Never)]
	public static void HandleMinigameStartMessage(MinigameStartResponseMessage msg)
	{
	}

	[MessageRoute(XtCmd.MinigameCurrency, QueueMessageMode.Never)]
	public static void HandleMinigameCurrenceyMessage(MinigameCurrencyResponseMessage msg)
	{
	}
}
