namespace BestHTTP.SignalR.Messages
{
	public sealed class KeepAliveMessage : IServerMessage
	{
		MessageTypes IServerMessage.Type
		{
			get
			{
				return default(MessageTypes);
			}
		}

		void IServerMessage.Parse(object data)
		{
		}
	}
}
