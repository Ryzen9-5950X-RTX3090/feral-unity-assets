using Server;

[MessageRouteHandler]
public static class AchievementSrvHandler
{
	[MessageRoute("achievement.event.update", QueueMessageMode.Never)]
	private static void HandleAchievementUpdate(AchievementUpdateMessage message)
	{
	}
}
