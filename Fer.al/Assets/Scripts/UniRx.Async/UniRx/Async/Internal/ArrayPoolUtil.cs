using System;
using System.Collections.Generic;

namespace UniRx.Async.Internal
{
	internal static class ArrayPoolUtil
	{
		public struct RentArray<T> : IDisposable
		{
			public readonly T[] Array;

			public readonly int Length;

			private ArrayPool<T> pool;

			public RentArray(T[] array, int length, ArrayPool<T> pool)
			{
			}

			public void Dispose()
			{
			}

			public void DisposeManually(bool clearArray)
			{
			}
		}

		internal static void EnsureCapacity<T>(ref T[] array, int index, ArrayPool<T> pool)
		{
		}

		private static void EnsureCapacityCore<T>(ref T[] array, int index, ArrayPool<T> pool)
		{
		}

		public static RentArray<T> Materialize<T>(IEnumerable<T> source)
		{
			return default(RentArray<T>);
		}
	}
}
