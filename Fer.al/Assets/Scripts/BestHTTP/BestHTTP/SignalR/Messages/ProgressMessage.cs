using System.Runtime.CompilerServices;

namespace BestHTTP.SignalR.Messages
{
	public sealed class ProgressMessage : IServerMessage, IHubMessage
	{
		MessageTypes IServerMessage.Type
		{
			get
			{
				return default(MessageTypes);
			}
		}

		public ulong InvocationId
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public double Progress
		{
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		void IServerMessage.Parse(object data)
		{
		}
	}
}
