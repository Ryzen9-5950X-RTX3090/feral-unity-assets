using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Amazon.Runtime.Internal.Util
{
	internal class Cache<TKey, TValue> : ICache<TKey, TValue>, ICache
	{
		private class CacheItem<T>
		{
			private T _value;

			public T Value
			{
				get
				{
					return (T)null;
				}
				private set
				{
				}
			}

			public DateTime LastUseTime
			{
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public CacheItem(T value)
			{
			}
		}

		private Dictionary<TKey, CacheItem<TValue>> Contents;

		private readonly object CacheLock;

		public static TimeSpan DefaultMaximumItemLifespan;

		public static TimeSpan DefaultCacheClearPeriod;

		private TimeSpan maximumItemLifespan;

		private TimeSpan cacheClearPeriod;

		public DateTime LastCacheClean
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<TKey> Keys
		{
			get
			{
				return null;
			}
		}

		public TimeSpan MaximumItemLifespan
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		public TimeSpan CacheClearPeriod
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		public int ItemCount
		{
			get
			{
				return default(int);
			}
		}

		public Cache([Optional] IEqualityComparer<TKey> keyComparer)
		{
		}

		public TValue GetValue(TKey key, Func<TKey, TValue> creator)
		{
			return (TValue)null;
		}

		public TValue GetValue(TKey key, Func<TKey, TValue> creator, out bool isStaleItem)
		{
			return (TValue)null;
		}

		public void Clear(TKey key)
		{
		}

		public void Clear()
		{
		}

		public TOut UseCache<TOut>(TKey key, Func<TOut> operation, Action onError, Predicate<Exception> shouldRetryForException)
		{
			return (TOut)null;
		}

		private TValue GetValueHelper(TKey key, out bool isStaleItem, [Optional] Func<TKey, TValue> creator)
		{
			return (TValue)null;
		}

		private bool IsValidItem(CacheItem<TValue> item)
		{
			return default(bool);
		}

		private void RemoveOldItems_Locked()
		{
		}

		private static DateTime GetCorrectedLocalTime()
		{
			return default(DateTime);
		}
	}
}
