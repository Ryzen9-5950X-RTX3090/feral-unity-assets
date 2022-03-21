using System.IO;

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarBuffer
	{
		private Stream inputStream;

		private Stream outputStream;

		private byte[] recordBuffer;

		private int currentBlockIndex;

		private int currentRecordIndex;

		private int recordSize;

		private int blockFactor;

		private bool isStreamOwner_;

		public int RecordSize
		{
			get
			{
				return default(int);
			}
		}

		public int BlockFactor
		{
			get
			{
				return default(int);
			}
		}

		public int CurrentBlock
		{
			get
			{
				return default(int);
			}
		}

		public int CurrentRecord
		{
			get
			{
				return default(int);
			}
		}

		protected TarBuffer()
		{
		}

		public static TarBuffer CreateInputTarBuffer(Stream inputStream, int blockFactor)
		{
			return null;
		}

		private void Initialize(int archiveBlockFactor)
		{
		}

		public static bool IsEndOfArchiveBlock(byte[] block)
		{
			return default(bool);
		}

		public byte[] ReadBlock()
		{
			return null;
		}

		private bool ReadRecord()
		{
			return default(bool);
		}

		public void WriteBlock(byte[] block)
		{
		}

		public void WriteBlock(byte[] buffer, int offset)
		{
		}

		private void WriteRecord()
		{
		}

		private void WriteFinalRecord()
		{
		}

		public void Close()
		{
		}
	}
}
