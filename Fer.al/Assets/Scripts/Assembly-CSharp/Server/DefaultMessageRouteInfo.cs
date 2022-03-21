using System;

namespace Server
{
	internal class DefaultMessageRouteInfo : MessageRouteInfo
	{
		private delegate void MessageManagerDelegate<T>(string id, T msg);

		public string eventId;

		private static object[] _args;

		public DefaultMessageRouteInfo(string eventId, Type msgType, QueueMessageMode queueMode)
		{
		}

		public override void OnMessage(NetworkMessage message)
		{
		}
	}
}
