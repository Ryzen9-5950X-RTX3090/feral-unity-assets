using System;
using System.Collections.Generic;

namespace Candlelight
{
	public static class HashPool<T>
	{
		public struct Scope : IDisposable
		{
			private HashSet<T> m_HashSet;

			public HashSet<T> HashSet
			{
				get
				{
					return null;
				}
			}

			public void Dispose()
			{
			}
		}

		private static readonly ObjectPool<HashSet<T>> s_Pool;

		public static HashSet<T> Get()
		{
			return null;
		}

		public static void Release(HashSet<T> hashSet)
		{
		}
	}
}
