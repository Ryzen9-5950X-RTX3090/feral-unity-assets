using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BestHTTP.Caching
{
	public static class HTTPCacheService
	{
		private const int LibraryVersion = 3;

		private static bool isSupported;

		private static bool IsSupportCheckDone;

		private static Dictionary<Uri, HTTPCacheFileInfo> library;

		private static ReaderWriterLockSlim rwLock;

		private static Dictionary<ulong, HTTPCacheFileInfo> UsedIndexes;

		private static bool InClearThread;

		private static bool InMaintainenceThread;

		private static ulong NextNameIDX;

		public static bool IsSupported
		{
			get
			{
				return default(bool);
			}
		}

		internal static string CacheFolder
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

		private static string LibraryPath
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

		public static bool IsDoingMaintainence
		{
			get
			{
				return default(bool);
			}
		}

		static HTTPCacheService()
		{
		}

		internal static void CheckSetup()
		{
		}

		internal static void SetupCacheFolder()
		{
		}

		internal static ulong GetNameIdx()
		{
			return default(ulong);
		}

		public static bool HasEntity(Uri uri)
		{
			return default(bool);
		}

		public static bool DeleteEntity(Uri uri, bool removeFromLibrary = true)
		{
			return default(bool);
		}

		private static void DeleteEntityImpl(Uri uri, bool removeFromLibrary = true, bool useLocking = false)
		{
		}

		internal static bool IsCachedEntityExpiresInTheFuture(HTTPRequest request)
		{
			return default(bool);
		}

		internal static void SetHeaders(HTTPRequest request)
		{
		}

		public static HTTPCacheFileInfo GetEntity(Uri uri)
		{
			return null;
		}

		internal static HTTPResponse GetFullResponse(HTTPRequest request)
		{
			return null;
		}

		internal static bool IsCacheble(Uri uri, HTTPMethods method, HTTPResponse response)
		{
			return default(bool);
		}

		internal static HTTPCacheFileInfo Store(Uri uri, HTTPMethods method, HTTPResponse response)
		{
			return null;
		}

		internal static void SetUpCachingValues(Uri uri, HTTPResponse response)
		{
		}

		internal static Stream PrepareStreamed(Uri uri, HTTPResponse response)
		{
			return null;
		}

		public static void BeginClear()
		{
		}

		private static void ClearImpl()
		{
		}

		public static void BeginMaintainence(HTTPCacheMaintananceParams maintananceParam)
		{
		}

		private static void MaintananceImpl(HTTPCacheMaintananceParams maintananceParam)
		{
		}

		public static int GetCacheEntityCount()
		{
			return default(int);
		}

		public static ulong GetCacheSize()
		{
			return default(ulong);
		}

		private static ulong GetCacheSizeImpl()
		{
			return default(ulong);
		}

		private static void LoadLibrary()
		{
		}

		internal static void SaveLibrary()
		{
		}

		internal static void SetBodyLength(Uri uri, int bodyLength)
		{
		}

		private static void DeleteUnusedFiles()
		{
		}
	}
}
