using System;

public static class WebResponses
{
	[Serializable]
	public class Login
	{
		[Serializable]
		public class GameServerData
		{
			public string blueboxServer;

			public string smartfoxServer;
		}

		[Serializable]
		public class UserData
		{
			public int id;

			public string email;
		}

		public int id;

		public string screen_name;

		public string language;

		public int game_account_type;

		public string web_auth_token;

		public string game_auth_token;

		public GameServerData game_server;

		public int expiry_in_days;

		public bool immortal;

		public UserData user;

		public string uuid;

		public bool rename_required;

		public string token;
	}

	[Serializable]
	public class AvailableGameServers
	{
		public string blueboxServer;

		public string smartfoxServer;

		public LoginStatus status;
	}
}
