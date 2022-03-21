using System;
using System.IO;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Ionic.Zlib;

namespace Amazon.Runtime.Internal.Transform
{
	public abstract class UnmarshallerContext : IDisposable
	{
		private bool disposed;

		protected bool MaintainResponseBody
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected bool IsException
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected CrcCalculatorStream CrcStream
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

		protected int Crc32Result
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

		protected IWebResponseData WebResponseData
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

		protected CachingWrapperStream WrappingStream
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

		public string ResponseBody
		{
			get
			{
				return null;
			}
		}

		public IWebResponseData ResponseData
		{
			get
			{
				return null;
			}
		}

		public abstract string CurrentPath { get; }

		public abstract int CurrentDepth { get; }

		public abstract bool IsStartElement { get; }

		public abstract bool IsEndElement { get; }

		public abstract bool IsStartOfDocument { get; }

		public byte[] GetResponseBodyBytes()
		{
			return null;
		}

		internal void ValidateCRC32IfAvailable()
		{
		}

		protected void SetupCRCStream(IWebResponseData responseData, Stream responseStream, long contentLength)
		{
		}

		public bool TestExpression(string expression)
		{
			return default(bool);
		}

		public bool TestExpression(string expression, int startingStackDepth)
		{
			return default(bool);
		}

		public bool ReadAtDepth(int targetDepth)
		{
			return default(bool);
		}

		private static bool TestExpression(string expression, string currentPath)
		{
			return default(bool);
		}

		private static bool TestExpression(string expression, int startingStackDepth, string currentPath, int currentDepth)
		{
			return default(bool);
		}

		public abstract bool Read();

		public abstract string ReadText();

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}
	}
}
