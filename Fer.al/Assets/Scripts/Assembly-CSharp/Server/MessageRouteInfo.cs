using System;
using System.Reflection;

namespace Server
{
	internal class MessageRouteInfo
	{
		public MethodInfo handlerMethod;

		public MessageRouter.ShouldQueuePredicate shouldQueue;

		public Type msgType;

		private static object[] _args;

		public MessageRouteInfo(MethodInfo handlerMethod, Type msgType, QueueMessageMode queueMode)
		{
		}

		public virtual void OnMessage(NetworkMessage message)
		{
		}
	}
}
