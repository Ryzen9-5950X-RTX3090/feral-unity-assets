namespace Server.Fake
{
	[MessageRouteHandler]
	public class RoomHandler
	{
		[FakeMessageRoute(XtCmd.RoomJoin)]
		public static void HandleRoomJoin(RoomJoinFakeRequest message)
		{
		}
	}
}
