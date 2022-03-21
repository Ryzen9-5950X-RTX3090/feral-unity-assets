using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Util
{
	public class LruCache<TKey, TValue> where TKey : class where TValue : class
	{
		private readonly object cacheLock;

		private Dictionary<TKey, LruListItem<TKey, TValue>> cache;

		private LruList<TKey, TValue> lruList;

		public int MaxEntries
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public LruCache(int maxEntries)
		{
		}

		public void AddOrUpdate(TKey key, TValue value)
		{
		}

		public void Evict(TKey key)
		{
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		public TValue GetOrAdd(TKey key, Func<TKey, TValue> factory)
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
