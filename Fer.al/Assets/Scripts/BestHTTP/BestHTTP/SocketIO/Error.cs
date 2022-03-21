using System.Runtime.CompilerServices;

namespace BestHTTP.SocketIO
{
	public sealed class Error
	{
		public SocketIOErrors Code
		{
			[CompilerGenerated]
			get
			{
				return default(SocketIOErrors);
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

		public Error(SocketIOErrors code, string msg)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
