using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.SocketIO.Events
{
	internal sealed class EventDescriptor
	{
		private SocketIOCallback[] CallbackArray;

		public List<SocketIOCallback> Callbacks
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

		public bool OnlyOnce
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

		public bool AutoDecodePayload
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

		public EventDescriptor(bool onlyOnce, bool autoDecodePayload, SocketIOCallback callback)
		{
		}

		public void Call(Socket socket, Packet packet, object[] args)
		{
		}
	}
}
