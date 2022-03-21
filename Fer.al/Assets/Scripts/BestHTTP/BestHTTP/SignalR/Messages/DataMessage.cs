using System.Runtime.CompilerServices;

namespace BestHTTP.SignalR.Messages
{
	public sealed class DataMessage : IServerMessage
	{
		MessageTypes IServerMessage.Type
		{
			get
			{
				return default(MessageTypes);
			}
		}

		public object Data
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

		void IServerMessage.Parse(object data)
		{
		}
	}
}
