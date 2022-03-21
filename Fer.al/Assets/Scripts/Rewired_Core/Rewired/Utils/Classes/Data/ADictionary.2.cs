using System;
using System.Collections;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Data
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class ADictionary<TKey, TValue> : IEnumerable, IDictionary, ICollection, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>
	{
		[CustomClassObfuscation]
		[CustomObfuscation]
		internal struct Entry
		{
			public int hashCode;

			public int next;

			public TKey key;

			public TValue value;
		}

		[Serializable]
		[CustomObfuscation]
		[CustomClassObfuscation]
		public struct Enumerator : IDisposable, IEnumerator, IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>>
		{
			internal const int DictEntry = 1;

			internal const int KeyValuePair = 2;

			private ADictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;

			private int nlbIzkFWqZgWHDwirMvtyFNvieiE;

			private int sTgsnEJuUoRNnuSXfCYtcCJrAEKa;

			private KeyValuePair<TKey, TValue> hXsQEjeqlbsWHdImyyWjqLiDOxk;

			private int UNuIAkKRReJsfYxPDpRcmrPXtBQ;

			public KeyValuePair<TKey, TValue> Current
			{
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			DictionaryEntry IDictionaryEnumerator.Entry
			{
				get
				{
					return default(DictionaryEntry);
				}
			}

			object IDictionaryEnumerator.Key
			{
				get
				{
					return null;
				}
			}

			object IDictionaryEnumerator.Value
			{
				get
				{
					return null;
				}
			}

			internal Enumerator(ADictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			public void Dispose()
			{
			}

			void IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		[CustomClassObfuscation]
		[CustomObfuscation]
		public sealed class KeyCollection : IEnumerable, ICollection, IEnumerable<TKey>, ICollection<TKey>
		{
			[Serializable]
			[CustomObfuscation]
			[CustomClassObfuscation]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TKey>
			{
				private ADictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;

				private int sTgsnEJuUoRNnuSXfCYtcCJrAEKa;

				private int nlbIzkFWqZgWHDwirMvtyFNvieiE;

				private TKey hbRfzrSblKFuxxedFtFWaiLHbtl;

				public TKey Current
				{
					get
					{
						return (TKey)null;
					}
				}

				object IEnumerator.Current
				{
					get
					{
						return null;
					}
				}

				internal Enumerator(ADictionary<TKey, TValue> dictionary)
				{
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					return default(bool);
				}

				void IEnumerator.Reset()
				{
				}
			}

			private ADictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;

			public int Count
			{
				get
				{
					return default(int);
				}
			}

			bool ICollection<TKey>.IsReadOnly
			{
				get
				{
					return default(bool);
				}
			}

			bool ICollection.IsSynchronized
			{
				get
				{
					return default(bool);
				}
			}

			object ICollection.SyncRoot
			{
				get
				{
					return null;
				}
			}

			public KeyCollection(ADictionary<TKey, TValue> dictionary)
			{
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			public void CopyTo(TKey[] array, int index)
			{
			}

			void ICollection<TKey>.Add(TKey item)
			{
			}

			void ICollection<TKey>.Clear()
			{
			}

			bool ICollection<TKey>.Contains(TKey item)
			{
				return default(bool);
			}

			bool ICollection<TKey>.Remove(TKey item)
			{
				return default(bool);
			}

			IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}
		}

		[Serializable]
		[CustomObfuscation]
		[CustomClassObfuscation]
		public sealed class ValueCollection : IEnumerable, ICollection, ICollection<TValue>, IEnumerable<TValue>
		{
			[Serializable]
			[CustomObfuscation]
			[CustomClassObfuscation]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TValue>
			{
				private ADictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;

				private int sTgsnEJuUoRNnuSXfCYtcCJrAEKa;

				private int nlbIzkFWqZgWHDwirMvtyFNvieiE;

				private TValue cgNhrEKxwCsXVTwGCnhEJKQDBKow;

				public TValue Current
				{
					get
					{
						return (TValue)null;
					}
				}

				object IEnumerator.Current
				{
					get
					{
						return null;
					}
				}

				internal Enumerator(ADictionary<TKey, TValue> dictionary)
				{
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					return default(bool);
				}

				void IEnumerator.Reset()
				{
				}
			}

			private ADictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;

			public int Count
			{
				get
				{
					return default(int);
				}
			}

			bool ICollection<TValue>.IsReadOnly
			{
				get
				{
					return default(bool);
				}
			}

			bool ICollection.IsSynchronized
			{
				get
				{
					return default(bool);
				}
			}

			object ICollection.SyncRoot
			{
				get
				{
					return null;
				}
			}

			public ValueCollection(ADictionary<TKey, TValue> dictionary)
			{
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			public void CopyTo(TValue[] array, int index)
			{
			}

			void ICollection<TValue>.Add(TValue item)
			{
			}

			bool ICollection<TValue>.Remove(TValue item)
			{
				return default(bool);
			}

			void ICollection<TValue>.Clear()
			{
			}

			bool ICollection<TValue>.Contains(TValue item)
			{
				return default(bool);
			}

			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}
		}

		private const string iywZuyOxphtuNibzHwTawJAHFjQ = "Version";

		private const string cbHizAgOdHuBBLmAtJiMKjFnccF = "HashSize";

		private const string caehSiMfmWBCkGgBshSpDrOIEjup = "KeyValuePairs";

		private const string oPjNonZKkECUyVifoZubTVnhBlr = "Comparer";

		private int[] gQzPpqxRCmDNjjxvzJMrNaplFRED;

		internal Entry[] _entries;

		internal int _count;

		private int wNPCYmLfYxcqAQsDPfNrFaPUdXp;

		private int eAqOfpDiFlECOPQSEyCBEyeaJpW;

		private int HYKCXxgFhrAgggiphnfYgWJyhYIc;

		private int XTFGxgGBgKoAOtuHtZmXVHQvrqx;

		private IEqualityComparer<TKey> ONmdwHaXVKXTucZhYdWHNijhbip;

		private IEqualityComparer<TValue> sOxEPvSrUSxFDEuOTOmAAtxWhRD;

		private KeyCollection BtcuDhDnnSEohOGNhSbOXqnStyP;

		private ValueCollection aEwRyncXwnIZMjJrXWDaBZXESTP;

		private readonly object vYiBUIHFosLSVhIQAioByfsCKmi;

		private static readonly bool SidKWeuekvleteANqUttcMdXPoQ;

		private static readonly bool gMHfftmWPtiXwIpBQtvOIqmmThy;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public int TotalCount
		{
			get
			{
				return default(int);
			}
		}

		public KeyCollection Keys
		{
			get
			{
				return null;
			}
		}

		public ValueCollection Values
		{
			get
			{
				return null;
			}
		}

		public IEqualityComparer<TKey> KeyComparer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IEqualityComparer<TValue> ValueComparer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TValue this[TKey key]
		{
			get
			{
				return (TValue)null;
			}
			set
			{
			}
		}

		public int IndexOfFirst
		{
			get
			{
				return default(int);
			}
		}

		public int IndexOfLast
		{
			get
			{
				return default(int);
			}
		}

		ICollection<TKey> IDictionary<TKey, TValue>.Keys
		{
			get
			{
				return null;
			}
		}

		ICollection<TValue> IDictionary<TKey, TValue>.Values
		{
			get
			{
				return null;
			}
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		bool ICollection.IsSynchronized
		{
			get
			{
				return default(bool);
			}
		}

		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		bool IDictionary.IsFixedSize
		{
			get
			{
				return default(bool);
			}
		}

		bool IDictionary.IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		ICollection IDictionary.Keys
		{
			get
			{
				return null;
			}
		}

		ICollection IDictionary.Values
		{
			get
			{
				return null;
			}
		}

		object IDictionary.this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ADictionary()
		{
		}

		public ADictionary(IEqualityComparer<TKey> keyComparer)
		{
		}

		public ADictionary(IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
		{
		}

		public ADictionary(int capacity)
		{
		}

		public ADictionary(int capacity, IEqualityComparer<TKey> keyComparer)
		{
		}

		public ADictionary(int capacity, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
		{
		}

		public ADictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		public ADictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> keyComparer)
		{
		}

		public ADictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
		{
		}

		public void Add(TKey key, TValue value)
		{
		}

		public void Clear()
		{
		}

		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		public bool Remove(TKey key)
		{
			return default(bool);
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		public TValue GetValueSafe(TKey key)
		{
			return (TValue)null;
		}

		public int IndexOfKey(TKey key)
		{
			return default(int);
		}

		public int IndexOfValue(TValue value)
		{
			return default(int);
		}

		public bool IsValidAt(int index)
		{
			return default(bool);
		}

		public TKey GetKeyAt(int index)
		{
			return (TKey)null;
		}

		public TValue GetValueAt(int index)
		{
			return (TValue)null;
		}

		public KeyValuePair<TKey, TValue> GetEntryAt(int index)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		public bool TryGetKeyAt(int index, out TKey key)
		{
			return default(bool);
		}

		public bool TryGetValueAt(int index, out TValue value)
		{
			return default(bool);
		}

		public bool TryGetEntryAt(int index, out KeyValuePair<TKey, TValue> entry)
		{
			return default(bool);
		}

		public bool GetNextIndex(ref int index)
		{
			return default(bool);
		}

		public int GetNextIndex(int index)
		{
			return default(int);
		}

		public bool GetNextKey(ref int index, out TKey key)
		{
			return default(bool);
		}

		public bool GetNextValue(ref int index, out TValue value)
		{
			return default(bool);
		}

		public bool GetNextEntry(ref int index, out KeyValuePair<TKey, TValue> entry)
		{
			return default(bool);
		}

		public bool GetPreviousIndex(ref int index)
		{
			return default(bool);
		}

		public int GetPreviousIndex(int index)
		{
			return default(int);
		}

		public bool GetPreviousKey(ref int index, out TKey key)
		{
			return default(bool);
		}

		public bool GetPreviousValue(ref int index, out TValue value)
		{
			return default(bool);
		}

		public bool GetPreviousEntry(ref int index, out KeyValuePair<TKey, TValue> entry)
		{
			return default(bool);
		}

		public bool RemoveAt(int index)
		{
			return default(bool);
		}

		private void bjoCRSGKcKJqCGyTAcErfuLsGvoe(KeyValuePair<TKey, TValue>[] P_0, int P_1)
		{
		}

		private void ItdhavHGXcUkAhyjaCFbIXENJheh(int P_0)
		{
		}

		private void gGuUUojlLQdvAiowetCyHBwGjGrz(TKey P_0, TValue P_1, bool P_2)
		{
		}

		private void UGfPaKfKAIAknjNVXFiWfAahWzU()
		{
		}

		private void UGfPaKfKAIAknjNVXFiWfAahWzU(int P_0, bool P_1)
		{
		}

		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			return null;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default(bool);
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Add(object key, object value)
		{
		}

		bool IDictionary.Contains(object key)
		{
			return default(bool);
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Remove(object key)
		{
		}

		private static bool JvXanRonvbXUZIaiBBNFeXVoemD(object P_0)
		{
			return default(bool);
		}

		private static void TCzlRwKTuhIaiAJNIeAFFBrauxT<T>(object P_0, string P_1)
		{
		}
	}
}
