using System;
using System.Collections.Generic;
using System.Reflection;

namespace Server
{
	[MessageRouteHandler]
	public class MessageRouter
	{
		public delegate void MessageRoute(NetworkMessage inMsg);

		public delegate bool ShouldQueuePredicate();

		private static class ShouldQueue
		{
			public static bool Never()
			{
				return default(bool);
			}

			public static bool WhileLoading()
			{
				return default(bool);
			}
		}

		public class MultiMessage : ServerMessage
		{
			public readonly List<INetMessageReader> Messages;

			public MultiMessage(INetMessageReader message)
			{
			}
		}

		public const string XT_EVENTID_PREFIX = "xt.";

		private Dictionary<string, MessageRouteInfo> _table;

		private Queue<NetworkMessage> _queuedMessages;

		private Dictionary<string, float> _lastRequestTimes;

		private Dictionary<string, float> _redundantCmdTimeOverrides;

		internal static MethodInfo _defaultMessageHandlerMethod;

		internal static MethodInfo _defaultTaggedMessageHandlerMethod;

		private void CreateRoutes(bool fake = false)
		{
		}

		public void CreateFakeRoutes()
		{
		}

		private void CreateRoutesForType(Type type)
		{
		}

		public static void OnWebServiceMessage(string jsonData)
		{
		}

		[MessageRoute(XtCmd.MultiMessage, QueueMessageMode.Never)]
		private static void HandleMultiMessage(MultiMessage message)
		{
		}

		public static void OnServerMessage(INetMessageReader data)
		{
		}

		public static void OnFakeServerMessage(INetMessageReader incoming)
		{
		}

		private void OnMessage(NetworkMessage message, Queue<NetworkMessage> queue)
		{
		}

		public void DequeueMessages()
		{
		}

		public void AddRedudantCmdOverride(string cmd, float redundantTime)
		{
		}

		private bool CanSendMessage(string cmd)
		{
			return default(bool);
		}

		public void SendServiceRequest(PersistentServiceConnection connection, PersistentServiceRequest req)
		{
		}
	}
}
