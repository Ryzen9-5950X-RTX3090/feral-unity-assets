using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace BestHTTP.Caching
{
	public class HTTPCacheFileInfo : IComparable<HTTPCacheFileInfo>
	{
		public Uri Uri
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

		public DateTime LastAccess
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int BodyLength
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public string ETag
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

		public string LastModified
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

		public DateTime Expires
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long Age
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long MaxAge
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DateTime Date
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool MustRevalidate
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

		public bool NoCache
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

		public long StaleWhileRevalidate
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long StaleIfError
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DateTime Received
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string ConstructedPath
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

		internal ulong MappedNameIDX
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal HTTPCacheFileInfo(Uri uri)
		{
		}

		internal HTTPCacheFileInfo(Uri uri, DateTime lastAcces, int bodyLength)
		{
		}

		internal HTTPCacheFileInfo(Uri uri, BinaryReader reader, int version)
		{
		}

		internal void SaveTo(BinaryWriter writer)
		{
		}

		public string GetPath()
		{
			return null;
		}

		public bool IsExists()
		{
			return default(bool);
		}

		internal void Delete()
		{
		}

		private void Reset()
		{
		}

		internal void SetUpCachingValues(HTTPResponse response)
		{
		}

		public bool WillExpireInTheFuture(bool isInError)
		{
			return default(bool);
		}

		internal void SetUpRevalidationHeaders(HTTPRequest request)
		{
		}

		public Stream GetBodyStream(out int length)
		{
			return null;
		}

		internal HTTPResponse ReadResponseTo(HTTPRequest request)
		{
			return null;
		}

		internal void Store(HTTPResponse response)
		{
		}

		internal Stream GetSaveStream(HTTPResponse response)
		{
			return null;
		}

		public int CompareTo(HTTPCacheFileInfo other)
		{
			return default(int);
		}
	}
}
