using System;

namespace CodeStage.AntiCheat.Utils
{
	internal class ThreadSafeRandom
	{
		private static readonly Random Global;

		[ThreadStatic]
		private static Random local;

		public static int Next(int minInclusive, int maxExclusive)
		{
			return default(int);
		}

		public static long NextLong(long minInclusive, long maxExclusive)
		{
			return default(long);
		}

		public static void NextBytes(byte[] buffer)
		{
		}

		public static void NextChars(char[] buffer)
		{
		}

		public static int Next()
		{
			return default(int);
		}

		public static int Next(int maxExclusive)
		{
			return default(int);
		}

		private static long NextLong(Random random, long minInclusive, long maxExclusive)
		{
			return default(long);
		}

		private static void NextChars(Random random, char[] buffer)
		{
		}
	}
}
