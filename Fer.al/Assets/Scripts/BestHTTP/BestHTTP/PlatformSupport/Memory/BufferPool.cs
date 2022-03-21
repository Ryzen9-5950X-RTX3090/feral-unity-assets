using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using BestHTTP.PlatformSupport.IL2CPP;

namespace BestHTTP.PlatformSupport.Memory
{
	[Il2CppEagerStaticClassConstruction]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public static class BufferPool
	{
		public static readonly byte[] NoData;

		private static bool _isEnabled;

		public static TimeSpan RemoveOlderThan;

		public static TimeSpan RunMaintenanceEvery;

		public static long MinBufferSize;

		public static long MaxBufferSize;

		public static long MaxPoolSize;

		public static bool RemoveEmptyLists;

		public static bool IsDoubleReleaseCheckEnabled;

		private static readonly List<BufferStore> FreeBuffers;

		private static DateTime lastMaintenance;

		private static long PoolSize;

		private static long GetBuffers;

		private static long ReleaseBuffers;

		private static readonly StringBuilder statiscticsBuilder;

		private static readonly ReaderWriterLockSlim rwLock;

		public static bool IsEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		static BufferPool()
		{
		}

		public static byte[] Get(long size, bool canBeLarger)
		{
			return null;
		}

		public static void Release(BufferSegment segment)
		{
		}

		public static void Release(byte[] buffer)
		{
		}

		public static byte[] Resize(ref byte[] buffer, int newSize, bool canBeLarger, bool clear)
		{
			return null;
		}

		public static string GetStatistics(bool showEmptyBuffers = true)
		{
			return null;
		}

		public static void Clear()
		{
		}

		internal static void Maintain()
		{
		}

		private static bool IsPowerOfTwo(long x)
		{
			return default(bool);
		}

		private static long NextPowerOf2(long x)
		{
			return default(long);
		}

		private static BufferDesc FindFreeBuffer(long size, bool canBeLarger)
		{
			return default(BufferDesc);
		}

		private static void AddFreeBuffer(byte[] buffer)
		{
		}
	}
}
