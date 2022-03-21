using System.Runtime.CompilerServices;
using BestHTTP.Decompression.Zlib;
using BestHTTP.Extensions;
using BestHTTP.WebSocket.Frames;

namespace BestHTTP.WebSocket.Extensions
{
	public sealed class PerMessageCompression : IExtension
	{
		public const int MinDataLengthToCompressDefault = 256;

		private static readonly byte[] Trailer;

		private BufferPoolMemoryStream compressorOutputStream;

		private DeflateStream compressorDeflateStream;

		private BufferPoolMemoryStream decompressorInputStream;

		private BufferPoolMemoryStream decompressorOutputStream;

		private DeflateStream decompressorDeflateStream;

		public bool ClientNoContextTakeover
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

		public bool ServerNoContextTakeover
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

		public int ClientMaxWindowBits
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

		public int ServerMaxWindowBits
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

		public CompressionLevel Level
		{
			[CompilerGenerated]
			get
			{
				return default(CompressionLevel);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int MinimumDataLegthToCompress
		{
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

		public PerMessageCompression()
		{
		}

		public PerMessageCompression(CompressionLevel level, bool clientNoContextTakeover, bool serverNoContextTakeover, int desiredClientMaxWindowBits, int desiredServerMaxWindowBits, int minDatalengthToCompress)
		{
		}

		public void AddNegotiation(HTTPRequest request)
		{
		}

		public bool ParseNegotiation(WebSocketResponse resp)
		{
			return default(bool);
		}

		public byte GetFrameHeader(WebSocketFrame writer, byte inFlag)
		{
			return default(byte);
		}

		public byte[] Encode(WebSocketFrame writer)
		{
			return null;
		}

		public byte[] Decode(byte header, byte[] data, int length)
		{
			return null;
		}

		private byte[] Compress(byte[] data, int length)
		{
			return null;
		}

		private byte[] Decompress(byte[] data, int length)
		{
			return null;
		}
	}
}
