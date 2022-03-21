namespace Server.Fake
{
	public class RoomJoinFakeRequest : ServerMessage
	{
		public LevelDefComponent LevelDef;

		public RoomJoinFakeRequest(INetMessageReader data)
		{
		}
	}
}
