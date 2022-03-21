using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.SocketIO.Events
{
	internal sealed class EventTable
	{
		private Dictionary<string, List<EventDescriptor>> Table;

		private Socket Socket
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

		public EventTable(Socket socket)
		{
		}

		public void Register(string eventName, SocketIOCallback callback, bool onlyOnce, bool autoDecodePayload)
		{
		}

		public void Unregister(string eventName)
		{
		}

		public void Unregister(string eventName, SocketIOCallback callback)
		{
		}

		public void Call(string eventName, Packet packet, object[] args)
		{
		}

		public void Call(Packet packet)
		{
		}

		public void Clear()
		{
		}

		private bool ShouldDecodePayload(string eventName)
		{
			return default(bool);
		}

		private bool HasSubsciber(string eventName)
		{
			return default(bool);
		}
	}
}
