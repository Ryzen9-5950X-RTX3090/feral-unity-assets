using System.Runtime.CompilerServices;

namespace Server
{
	public class ServerMessage : NetworkMessage
	{
		public override string Cmd
		{
			get
			{
				return null;
			}
		}

		public INetMessageReader Data
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ServerMessage(INetMessageReader data)
		{
		}
	}
}
