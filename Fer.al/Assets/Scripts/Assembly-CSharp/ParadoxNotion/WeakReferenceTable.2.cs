using System;
using System.Collections.Generic;

namespace ParadoxNotion
{
	public class WeakReferenceTable<TKey, TValue> where TKey : class where TValue : IDisposable
	{
		private List<WeakReference<TKey>> keys;

		private List<TValue> values;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public void Clear()
		{
		}

		public void Add(TKey key, TValue value)
		{
		}

		public void Remove(TKey key)
		{
		}

		public bool TryGetValueWithRefCheck(TKey key, out TValue value)
		{
			return default(bool);
		}

		public void RemoveMissingReferences()
		{
		}

		private void CheckCount()
		{
		}
	}
}
