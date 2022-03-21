public class UserOnlineStatusMessage : Message
{
	public readonly string userUUID;

	public readonly OnlineStatus onlineStatus;

	public bool IsOnline
	{
		get
		{
			return default(bool);
		}
	}

	public UserOnlineStatusMessage(string inUserUUID, OnlineStatus inOnlineStatus)
	{
	}
}
