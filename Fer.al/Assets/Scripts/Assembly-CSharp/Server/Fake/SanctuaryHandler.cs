namespace Server.Fake
{
	[MessageRouteHandler]
	public class SanctuaryHandler
	{
		[FakeMessageRoute(XtCmd.SanctuaryJoin)]
		public static void HandleSanctuaryJoin(SanctuaryJoinFakeRequest message)
		{
		}
	}
}
