using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP.Decompression;

namespace BestHTTP.Connections.HTTP2
{
	public sealed class HTTP2Response : HTTPResponse
	{
		private bool isPrepared;

		private GZipDecompressor decompressor;

		public int ExpectedContentLength
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

		public bool IsCompressed
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

		public HTTP2Response(HTTPRequest request, bool isFromCache)
		{
		}

		internal void AddHeaders(List<KeyValuePair<string, string>> headers)
		{
		}

		internal void AddData(Stream stream)
		{
		}

		internal void ProcessData(byte[] payload, int payloadLength)
		{
		}

		internal void FinishProcessData()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
