using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP.Caching;
using BestHTTP.Cookies;
using BestHTTP.Extensions;
using BestHTTP.Logger;
using UnityEngine;

namespace BestHTTP
{
	public class HTTPResponse : IDisposable
	{
		internal const byte CR = 13;

		internal const byte LF = 10;

		public static int MinReadBufferSize;

		protected string dataAsText;

		protected Texture2D texture;

		internal long UnprocessedFragments;

		internal HTTPRequest baseRequest;

		protected Stream Stream;

		protected byte[] fragmentBuffer;

		protected int fragmentBufferDataLength;

		protected Stream cacheStream;

		protected int allFragmentSize;

		public int VersionMajor
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int VersionMinor
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int StatusCode
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool IsSuccess
		{
			get
			{
				return default(bool);
			}
		}

		public string Message
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool IsStreamed
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool IsFromCache
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public HTTPCacheFileInfo CacheFileInfo
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public bool IsCacheOnly
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

		public bool IsProxyResponse
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

		public Dictionary<string, List<string>> Headers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
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
			internal set
			{
			}
		}

		public bool IsUpgraded
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public List<Cookie> Cookies
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public string DataAsText
		{
			get
			{
				return null;
			}
		}

		public Texture2D DataAsTexture2D
		{
			get
			{
				return null;
			}
		}

		public bool IsClosedManually
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public LoggingContext Context
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

		protected HTTPResponse(HTTPRequest request, bool isFromCache)
		{
		}

		public HTTPResponse(HTTPRequest request, Stream stream, bool isStreamed, bool isFromCache, bool isProxyResponse = false)
		{
		}

		public virtual bool Receive(int forceReadRawContentLength = -1, bool readPayloadData = true, bool sendUpgradedEvent = true)
		{
			return default(bool);
		}

		protected bool ReadPayload(int forceReadRawContentLength)
		{
			return default(bool);
		}

		protected void ReadHeaders(Stream stream)
		{
		}

		public void AddHeader(string name, string value)
		{
		}

		public List<string> GetHeaderValues(string name)
		{
			return null;
		}

		public string GetFirstHeaderValue(string name)
		{
			return null;
		}

		public bool HasHeaderWithValue(string headerName, string value)
		{
			return default(bool);
		}

		public bool HasHeader(string headerName)
		{
			return default(bool);
		}

		public HTTPRange GetRange()
		{
			return null;
		}

		internal static string ReadTo(Stream stream, byte blocker)
		{
			return null;
		}

		internal static string ReadTo(Stream stream, byte blocker1, byte blocker2)
		{
			return null;
		}

		internal static string NoTrimReadTo(Stream stream, byte blocker1, byte blocker2)
		{
			return null;
		}

		protected int ReadChunkLength(Stream stream)
		{
			return default(int);
		}

		protected void ReadChunked(Stream stream)
		{
		}

		internal void ReadRaw(Stream stream, long contentLength)
		{
		}

		protected void ReadUnknownSize(Stream stream)
		{
		}

		protected byte[] DecodeStream(BufferPoolMemoryStream streamToDecode)
		{
			return null;
		}

		protected void BeginReceiveStreamFragments()
		{
		}

		protected void FeedStreamFragment(byte[] buffer, int pos, int length)
		{
		}

		protected void FlushRemainingFragmentBuffer()
		{
		}

		protected void AddStreamedFragment(byte[] buffer, int bufferLength)
		{
		}

		private bool FragmentQueueIsFull()
		{
			return default(bool);
		}

		private void VerboseLogging(string str)
		{
		}

		public void Dispose()
		{
		}

		~HTTPResponse()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
