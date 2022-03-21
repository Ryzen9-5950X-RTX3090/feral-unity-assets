using System;
using System.Collections.Generic;

namespace UniRx.Async
{
	public static class EnumerableAsyncExtensions
	{
		public static IEnumerable<UniTask> Select<T>(this IEnumerable<T> source, Func<T, UniTask> selector)
		{
			return null;
		}

		public static IEnumerable<UniTask<TR>> Select<TR, T>(this IEnumerable<T> source, Func<T, UniTask<TR>> selector)
		{
			return null;
		}

		public static IEnumerable<UniTask> Select<T>(this IEnumerable<T> source, Func<T, int, UniTask> selector)
		{
			return null;
		}

		public static IEnumerable<UniTask<TR>> Select<TR, T>(this IEnumerable<T> source, Func<T, int, UniTask<TR>> selector)
		{
			return null;
		}
	}
}
