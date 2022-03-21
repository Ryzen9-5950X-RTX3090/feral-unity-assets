using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace UniRx.Async.Internal
{
	internal class WeakDictionary<TKey, TValue> where TKey : class
	{
		private class Entry
		{
			public WeakReference<TKey> Key;

			public TValue Value;

			public int Hash;

			public Entry Prev;

			public Entry Next;

			public override string ToString()
			{
				return null;
			}

			private int Count()
			{
				return default(int);
			}
		}

		private Entry[] buckets;

		private int size;

		private SpinLock gate;

		private readonly float loadFactor;

		private readonly IEqualityComparer<TKey> keyEqualityComparer;

		public WeakDictionary(int capacity = 4, float loadFactor = 0.75f, [Optional] IEqualityComparer<TKey> keyComparer)
		{
		}

		public bool TryAdd(TKey key, TValue value)
		{
			return default(bool);
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		public bool TryRemove(TKey key)
		{
			return default(bool);
		}

		private bool TryAddInternal(TKey key, TValue value)
		{
			return default(bool);
		}

		private bool AddToBuckets(Entry[] targetBuckets, TKey newKey, TValue value, int keyHash)
		{
			return default(bool);
		}

		private bool TryGetEntry(TKey key, out int hashIndex, out Entry entry)
		{
			return default(bool);
		}

		private void Remove(int hashIndex, Entry entry)
		{
		}

		public List<KeyValuePair<TKey, TValue>> ToList()
		{
			return null;
		}

		public int ToList(ref List<KeyValuePair<TKey, TValue>> list, bool clear = true)
		{
			return default(int);
		}

		private static int CalculateCapacity(int collectionSize, float loadFactor)
		{
			return default(int);
		}
	}
}
