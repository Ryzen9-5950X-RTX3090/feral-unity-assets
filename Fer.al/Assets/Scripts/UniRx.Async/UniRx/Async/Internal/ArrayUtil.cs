using System;
using System.Collections.Generic;

namespace UniRx.Async.Internal
{
	internal static class ArrayUtil
	{
		public static void EnsureCapacity<T>(ref T[] array, int index)
		{
		}

		private static void EnsureCore<T>(ref T[] array, int index)
		{
		}

		public static ValueTuple<T[], int> Materialize<T>(IEnumerable<T> source)
		{
			return default(ValueTuple<T[], int>);
		}
	}
}
