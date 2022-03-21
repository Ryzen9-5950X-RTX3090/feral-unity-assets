using Server;
using WW.Debug;

[MessageRouteHandler]
public static class RoomXtHandler
{
	public enum ReconnectionType
	{
		None,
		Normal,
		Sanctuary,
		User
	}

	public static ReconnectionType reconnectType;

	public static void RequestJoinRoom(LevelDefComponent levelDef)
	{
	}

	[MessageSender(XtCmd.RoomJoin, false)]
	private static void RequestJoinRoom(string roomDefId, bool isNodeHop)
	{
	}

	[MessageSender(XtCmd.RoomJoinTutorial, false)]
	public static void RequestJoinRoomTutorial()
	{
	}

	[DebugButton("RoomJoinPrevious", "Minigame", true, false)]
	[MessageSender(XtCmd.RoomJoinPrevious, false)]
	public static void RequestJoinPreviousRoom()
	{
	}

	[MessageRoute(XtCmd.RoomJoin, QueueMessageMode.Never)]
	private static void HandleRoomJoin(RoomJoinMessage message)
	{
	}
}
