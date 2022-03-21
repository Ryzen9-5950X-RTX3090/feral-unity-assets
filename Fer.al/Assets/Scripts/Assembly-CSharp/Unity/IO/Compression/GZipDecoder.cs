using System;

namespace Unity.IO.Compression
{
	internal class GZipDecoder : IFileFormatReader
	{
		internal enum GzipHeaderState
		{
			ReadingID1,
			ReadingID2,
			ReadingCM,
			ReadingFLG,
			ReadingMMTime,
			ReadingXFL,
			ReadingOS,
			ReadingXLen1,
			ReadingXLen2,
			ReadingXLenData,
			ReadingFileName,
			ReadingComment,
			ReadingCRC16Part1,
			ReadingCRC16Part2,
			Done,
			ReadingCRC,
			ReadingFileSize
		}

		[Flags]
		internal enum GZipOptionalHeaderFlags
		{
			CRCFlag = 2,
			ExtraFieldsFlag = 4,
			FileNameFlag = 8,
			CommentFlag = 0x10
		}

		private GzipHeaderState gzipHeaderSubstate;

		private GzipHeaderState gzipFooterSubstate;

		private int gzip_header_flag;

		private int gzip_header_xlen;

		private uint expectedCrc32;

		private uint expectedOutputStreamSizeModulo;

		private int loopCounter;

		private uint actualCrc32;

		private long actualStreamSizeModulo;

		public void Reset()
		{
		}

		public bool ReadHeader(InputBuffer input)
		{
			return default(bool);
		}

		public bool ReadFooter(InputBuffer input)
		{
			return default(bool);
		}

		public void UpdateWithBytesRead(byte[] buffer, int offset, int copied)
		{
		}

		public void Validate()
		{
		}
	}
}
