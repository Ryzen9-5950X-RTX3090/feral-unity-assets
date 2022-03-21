using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace BestHTTP.WebSocket.Frames
{
	public struct WebSocketFrameReader
	{
		public byte Header
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsFinal
		{
			[IsReadOnly]
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

		public WebSocketFrameTypes Type
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(WebSocketFrameTypes);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool HasMask
		{
			[IsReadOnly]
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

		public ulong Length
		{
			[IsReadOnly]
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

		public byte[] Data
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

		public string DataAsText
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

		internal void Read(Stream stream)
		{
		}

		private byte ReadByte(Stream stream)
		{
			return default(byte);
		}

		public void Assemble(List<WebSocketFrameReader> fragments)
		{
		}

		public void DecodeWithExtensions(WebSocket webSocket)
		{
		}

		public void ReleaseData()
		{
		}
	}
}
