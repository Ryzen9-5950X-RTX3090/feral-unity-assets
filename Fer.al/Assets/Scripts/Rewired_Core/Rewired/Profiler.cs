using System.Diagnostics;
using UnityEngine;

namespace Rewired
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal static class Profiler
	{
		private const string dZDghludsKNFVhhyDxwLRtVVENd = "USE_PROFILER must be set in Rewired Core to use the profiler.";

		public static bool enableBinaryLog
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static bool enabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static string logFile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool supported
		{
			get
			{
				return default(bool);
			}
		}

		public static uint usedHeapSize
		{
			get
			{
				return default(uint);
			}
		}

		public static long usedHeapSizeLong
		{
			get
			{
				return default(long);
			}
		}

		private static void fYQpZsjADBzJFmMzTCGrWtbjPzd()
		{
		}

		[Conditional("ENABLE_PROFILER")]
		public static void AddFramesFromFile(string file)
		{
		}

		[Conditional("ENABLE_PROFILER")]
		public static void BeginSample(string name)
		{
		}

		[Conditional("ENABLE_PROFILER")]
		public static void BeginSample(string name, Object targetObject)
		{
		}

		[Conditional("ENABLE_PROFILER")]
		public static void EndSample()
		{
		}

		public static uint GetMonoHeapSize()
		{
			return default(uint);
		}

		public static long GetMonoHeapSizeLong()
		{
			return default(long);
		}

		public static uint GetMonoUsedSize()
		{
			return default(uint);
		}

		public static long GetMonoUsedSizeLong()
		{
			return default(long);
		}

		public static int GetRuntimeMemorySize(Object o)
		{
			return default(int);
		}

		public static long GetRuntimeMemorySizeLong(Object o)
		{
			return default(long);
		}

		public static uint GetTotalAllocatedMemory()
		{
			return default(uint);
		}

		public static long GetTotalAllocatedMemoryLong()
		{
			return default(long);
		}

		public static uint GetTotalReservedMemory()
		{
			return default(uint);
		}

		public static long GetTotalReservedMemoryLong()
		{
			return default(long);
		}

		public static uint GetTotalUnusedReservedMemory()
		{
			return default(uint);
		}

		public static long GetTotalUnusedReservedMemoryLong()
		{
			return default(long);
		}
	}
}
