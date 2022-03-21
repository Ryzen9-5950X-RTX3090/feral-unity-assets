using System;
using System.IO;
using System.Security;

namespace Unity.IO.Compression
{
	public class DeflateStream : Stream
	{
		internal delegate void AsyncWriteDelegate(byte[] array, int offset, int count, bool isAsync);

		private enum WorkerType : byte
		{
			Managed,
			Unknown
		}

		internal const int DefaultBufferSize = 8192;

		private Stream _stream;

		private CompressionMode _mode;

		private bool _leaveOpen;

		private Inflater inflater;

		private IDeflater deflater;

		private byte[] buffer;

		private int asyncOperations;

		private readonly AsyncCallback m_CallBack;

		private readonly AsyncWriteDelegate m_AsyncWriterDelegate;

		private IFileFormatWriter formatWriter;

		private bool wroteHeader;

		private bool wroteBytes;

		public Stream BaseStream
		{
			get
			{
				return null;
			}
		}

		public override bool CanRead
		{
			get
			{
				return default(bool);
			}
		}

		public override bool CanWrite
		{
			get
			{
				return default(bool);
			}
		}

		public override bool CanSeek
		{
			get
			{
				return default(bool);
			}
		}

		public override long Length
		{
			get
			{
				return default(long);
			}
		}

		public override long Position
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public DeflateStream(Stream stream, CompressionMode mode)
		{
		}

		public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		private static IDeflater CreateDeflater()
		{
			return null;
		}

		[SecuritySafeCritical]
		private static WorkerType GetDeflaterType()
		{
			return default(WorkerType);
		}

		internal void SetFileFormatReader(IFileFormatReader reader)
		{
		}

		internal void SetFileFormatWriter(IFileFormatWriter writer)
		{
		}

		public override void Flush()
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		public override void SetLength(long value)
		{
		}

		public override int Read(byte[] array, int offset, int count)
		{
			return default(int);
		}

		private void ValidateParameters(byte[] array, int offset, int count)
		{
		}

		private void EnsureNotDisposed()
		{
		}

		private void EnsureDecompressionMode()
		{
		}

		private void EnsureCompressionMode()
		{
		}

		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		private void ReadCallback(IAsyncResult baseStreamResult)
		{
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return default(int);
		}

		public override void Write(byte[] array, int offset, int count)
		{
		}

		internal void InternalWrite(byte[] array, int offset, int count, bool isAsync)
		{
		}

		private void WriteDeflaterOutput(bool isAsync)
		{
		}

		private void DoWrite(byte[] array, int offset, int count, bool isAsync)
		{
		}

		private void DoMaintenance(byte[] array, int offset, int count)
		{
		}

		private void PurgeBuffers(bool disposing)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		private void WriteCallback(IAsyncResult asyncResult)
		{
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		private void CheckEndXxxxLegalStateAndParams(IAsyncResult asyncResult)
		{
		}

		private void AwaitAsyncResultCompletion(DeflateStreamAsyncResult asyncResult)
		{
		}
	}
}
