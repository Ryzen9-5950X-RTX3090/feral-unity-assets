using System;
using System.Collections.Generic;

namespace Candlelight
{
	public static class DictPool<TKey, TValue>
	{
		public struct Scope : IDisposable
		{
			private Dictionary<TKey, TValue> m_Dict;

			public Dictionary<TKey, TValue> Dict
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

		private static readonly ObjectPool<Dictionary<TKey, TValue>> s_Pool;

		public static Dictionary<TKey, TValue> Get()
		{
			return null;
		}

		public static void Release(Dictionary<TKey, TValue> dictionary)
		{
		}
	}
}
