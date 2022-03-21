using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using BestHTTP.Extensions;

namespace BestHTTP
{
	public sealed class MultipartFormDataStream : Stream
	{
		private long _length;

		private string boundary;

		private Queue<StreamList> fields;

		private StreamList currentField;

		private bool prepared;

		public override bool CanRead
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

		public override bool CanWrite
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
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public MultipartFormDataStream(HTTPRequest request)
		{
		}

		public void AddField(string fieldName, string value)
		{
		}

		public void AddField(string fieldName, string value, Encoding encoding)
		{
		}

		public void AddStreamField(Stream stream, string fieldName)
		{
		}

		public void AddStreamField(Stream stream, string fieldName, string fileName)
		{
		}

		public void AddStreamField(Stream stream, string fieldName, string fileName, string mimeType)
		{
		}

		private void Prepare()
		{
		}

		public override int Read(byte[] buffer, int offset, int length)
		{
			return default(int);
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		public override void SetLength(long value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void Flush()
		{
		}
	}
}
