using Server;
using WW.Debug;

[MessageRouteHandler]
public static class GiftXtHandler
{
	[DebugButton("Gift Item", "Inventory", true, false)]
	public static void DebugButtonGiftEric1(string defId)
	{
	}

	[DebugButton("Gift Eric1", "Inventory", true, false)]
	public static void DebugButtonGiftEric2(string defId)
	{
	}

	[MessageSender(XtCmd.GiftGiveDEBUG, false)]
	public static void RequestGiveGiftDEBUG(string userId, string defId, ItemType itemType)
	{
	}

	[MessageSender(XtCmd.GiftRedeem, false)]
	public static void RequestRedeemGift(string itemId, bool accepted)
	{
	}

	[MessageSender(XtCmd.GiftRedeemMulti, false)]
	public static void RequestRedeemGiftMulti(string[] itemIds, bool accepted)
	{
	}

	[MessageRoute(XtCmd.GiftPush, QueueMessageMode.Never)]
	private static void HandleGiftPush(GiftPushMessage message)
	{
	}
}
