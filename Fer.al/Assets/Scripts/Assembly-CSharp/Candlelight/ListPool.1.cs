using System;
using System.Collections.Generic;

namespace Candlelight
{
	public static class ListPool<T>
	{
		public struct Scope : IDisposable
		{
			private List<T> m_List;

			public List<T> List
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

		private static readonly ObjectPool<List<T>> s_Pool;

		public static List<T> Get()
		{
			return null;
		}

		public static void Release(List<T> list)
		{
		}
	}
}
