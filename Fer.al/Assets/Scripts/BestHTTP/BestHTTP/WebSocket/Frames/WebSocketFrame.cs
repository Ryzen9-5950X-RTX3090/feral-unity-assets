using System.Runtime.CompilerServices;
using BestHTTP.PlatformSupport.IL2CPP;

namespace BestHTTP.WebSocket.Frames
{
	[Il2CppEagerStaticClassConstruction]
	public sealed class WebSocketFrame
	{
		public WebSocketFrameTypes Type
		{
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

		public bool IsFinal
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

		public byte Header
		{
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

		public byte[] Data
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

		public int DataLength
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

		public bool UseExtensions
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

		public override string ToString()
		{
			return null;
		}

		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data)
		{
		}

		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data, bool useExtensions)
		{
		}

		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data, bool isFinal, bool useExtensions)
		{
		}

		public WebSocketFrame(WebSocket webSocket, WebSocketFrameTypes type, byte[] data, ulong pos, ulong length, bool isFinal, bool useExtensions)
		{
		}

		public RawFrameData Get()
		{
			return default(RawFrameData);
		}

		public WebSocketFrame[] Fragment(uint maxFragmentSize)
		{
			return null;
		}
	}
}
