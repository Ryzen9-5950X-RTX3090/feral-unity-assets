using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.PlatformSupport.Memory;

namespace BestHTTP.SocketIO3
{
	public struct IncomingPacket
	{
		public static readonly IncomingPacket Empty;

		public TransportEventTypes TransportEvent
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(TransportEventTypes);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SocketIOEventTypes SocketIOEvent
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(SocketIOEventTypes);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Id
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Namespace
		{
			[IsReadOnly]
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

		public int AttachementCount
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<BufferSegment> Attachements
		{
			[IsReadOnly]
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

		public string EventName
		{
			[IsReadOnly]
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

		public object[] DecodedArgs
		{
			[IsReadOnly]
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

		public object DecodedArg
		{
			[IsReadOnly]
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

		public IncomingPacket(TransportEventTypes transportEvent, SocketIOEventTypes packetType, string nsp, int id)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(IncomingPacket packet)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static string GenerateAcknowledgementNameFromId(int id)
		{
			return null;
		}
	}
}
