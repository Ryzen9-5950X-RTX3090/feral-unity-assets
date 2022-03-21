using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.SocketIO.JsonEncoders;

namespace BestHTTP.SocketIO
{
	public sealed class Packet
	{
		private enum PayloadTypes : byte
		{
			Textual,
			Binary
		}

		public const string Placeholder = "_placeholder";

		private List<byte[]> attachments;

		public TransportEventTypes TransportEvent
		{
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

		public int AttachmentCount
		{
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

		public int Id
		{
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

		public string Payload
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

		public string EventName
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

		public List<byte[]> Attachments
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool HasAllAttachment
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsDecoded
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

		public object[] DecodedArgs
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

		internal Packet()
		{
		}

		internal Packet(string from)
		{
		}

		public Packet(TransportEventTypes transportEvent, SocketIOEventTypes packetType, string nsp, string payload, int attachment = 0, int id = 0)
		{
		}

		public object[] Decode(IJsonEncoder encoder)
		{
			return null;
		}

		public string DecodeEventName()
		{
			return null;
		}

		public string RemoveEventName(bool removeArrayMarks)
		{
			return null;
		}

		public bool ReconstructAttachmentAsIndex()
		{
			return default(bool);
		}

		public bool ReconstructAttachmentAsBase64()
		{
			return default(bool);
		}

		internal void Parse(string from)
		{
		}

		private int ToInt(char ch)
		{
			return default(int);
		}

		internal string Encode()
		{
			return null;
		}

		internal byte[] EncodeBinary()
		{
			return null;
		}

		internal void AddAttachmentFromServer(byte[] data, bool copyFull)
		{
		}

		private byte[] EncodeData(byte[] data, PayloadTypes type, byte[] afterHeaderData)
		{
			return null;
		}

		private bool PlaceholderReplacer(Action<string, Dictionary<string, object>> onFound)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}

		internal Packet Clone()
		{
			return null;
		}
	}
}
