namespace Server
{
	public class ServerLoginResponse : Message
	{
		public readonly LoginStatus Status;

		public readonly LoginData Data;

		public bool Success
		{
			get
			{
				return default(bool);
			}
		}

		public ServerLoginResponse(LoginStatus status, LoginData data)
		{
		}
	}
}
