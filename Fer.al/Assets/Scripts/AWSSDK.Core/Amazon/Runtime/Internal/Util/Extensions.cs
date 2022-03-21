using System.Diagnostics;
using System.Threading;

namespace Amazon.Runtime.Internal.Util
{
	public static class Extensions
	{
		private static readonly long TicksPerSecond;

		private static readonly double TickFrequency;

		public static long GetElapsedDateTimeTicks(this Stopwatch self)
		{
			return default(long);
		}

		public static bool HasRequestData(this IRequest request)
		{
			return default(bool);
		}

		public static bool Wait(this WaitHandle semaphore)
		{
			return default(bool);
		}

		public static void Dispose(this WaitHandle semaphore)
		{
		}
	}
}
