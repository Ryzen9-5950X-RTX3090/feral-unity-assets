using System.IO;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Internal.Util
{
	public class ChunkedUploadWrapperStream : WrapperStream
	{
		private enum ReadStrategy
		{
			ReadDirect,
			ReadAndCopy
		}

		public static readonly int DefaultChunkSize;

		private const string CLRF = "\r\n";

		private const string CHUNK_STRING_TO_SIGN_PREFIX = "AWS4-HMAC-SHA256-PAYLOAD";

		private const string CHUNK_SIGNATURE_HEADER = ";chunk-signature=";

		private const int SIGNATURE_LENGTH = 64;

		private byte[] _inputBuffer;

		private readonly byte[] _outputBuffer;

		private int _outputBufferPos;

		private int _outputBufferDataLen;

		private readonly int _wrappedStreamBufferSize;

		private bool _wrappedStreamConsumed;

		private bool _outputBufferIsTerminatingChunk;

		private readonly ReadStrategy _readStrategy;

		private AWS4SigningResult HeaderSigningResult
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

		private string PreviousChunkSignature
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

		public override long Length
		{
			get
			{
				return default(long);
			}
		}

		public override bool CanSeek
		{
			get
			{
				return default(bool);
			}
		}

		internal override bool HasLength
		{
			get
			{
				return default(bool);
			}
		}

		internal ChunkedUploadWrapperStream(Stream stream, int wrappedStreamBufferSize, AWS4SigningResult headerSigningResult)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		private int AdjustBufferAfterReading(byte[] buffer, int offset, int count, int bytesRead)
		{
			return default(int);
		}

		private void ConstructOutputBufferChunk(int dataLen)
		{
		}

		public static long ComputeChunkedContentLength(long originalLength)
		{
			return default(long);
		}

		private static long CalculateChunkHeaderLength(long chunkDataSize)
		{
			return default(long);
		}

		private int FillInputBuffer()
		{
			return default(int);
		}
	}
}
