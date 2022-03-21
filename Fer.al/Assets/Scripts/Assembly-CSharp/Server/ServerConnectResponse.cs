using System.Runtime.CompilerServices;

namespace Server
{
	public class ServerConnectResponse : Message
	{
		public bool Success
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Message
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ServerConnectResponse(bool success, string message = "")
		{
		}
	}
}
