using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils.Classes.Data
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class IndexedDictionary<TKey, TValue> : IEnumerable, IDictionary, ICollection, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, Rewired.Utils.Interfaces.IReadOnlyList<TValue>, IReadOnlyList
	{
		private struct UOusDtCirBqAIjcBOfSGoGGhxCF
		{
			public TKey XoHEbkEkUMHxDaeeeewSFKYIjOYZ;

			public TValue PLdosENimxvPBjeGrIWuaBaRuLxb;

			public UOusDtCirBqAIjcBOfSGoGGhxCF(TKey key, TValue value)
			{
			}

			public KeyValuePair<TKey, TValue> BdhfUzRDaYqMlTgFACuSGPOEEpu()
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Serializable]
		[CustomObfuscation]
		[CustomClassObfuscation]
		public struct Enumerator : IDisposable, IEnumerator, IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>>
		{
			internal const int DictEntry = 1;

			internal const int KeyValuePair = 2;

			private IndexedDictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;

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

			internal Enumerator(IndexedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
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
			[CustomClassObfuscation]
			[CustomObfuscation]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TKey>
			{
				private IndexedDictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;

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

				internal Enumerator(IndexedDictionary<TKey, TValue> dictionary)
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

			private IndexedDictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;

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

			public KeyCollection(IndexedDictionary<TKey, TValue> dictionary)
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
				private IndexedDictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;

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

				internal Enumerator(IndexedDictionary<TKey, TValue> dictionary)
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

			private IndexedDictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;

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

			public ValueCollection(IndexedDictionary<TKey, TValue> dictionary)
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

		private static readonly bool SidKWeuekvleteANqUttcMdXPoQ;

		private static readonly bool gMHfftmWPtiXwIpBQtvOIqmmThy;

		private IEqualityComparer<TKey> ONmdwHaXVKXTucZhYdWHNijhbip;

		private IEqualityComparer<TValue> sOxEPvSrUSxFDEuOTOmAAtxWhRD;

		private readonly AList<UOusDtCirBqAIjcBOfSGoGGhxCF> QDdpegUvplbleFLzyPPIlUNzJOf;

		private readonly ADictionary<TKey, int> chytxdnGkiCtXVpgexkcbEVFen;

		private bool XTKqqpPhZRQVXqlxpbamolLouUb;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public bool ContainsDuplicateKeys
		{
			get
			{
				return default(bool);
			}
		}

		public bool AllowDuplicateKeys
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public TValue this[int index]
		{
			get
			{
				return (TValue)null;
			}
			set
			{
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

		public ICollection<TKey> Keys
		{
			get
			{
				return null;
			}
		}

		public ICollection<TValue> Values
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

		TValue IDictionary<TKey, TValue>.this[TKey key]
		{
			get
			{
				return (TValue)null;
			}
			set
			{
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

		TValue Rewired.Utils.Interfaces.IReadOnlyList<TValue>.this[int P_0]
		{
			get
			{
				return (TValue)null;
			}
		}

		int IReadOnlyList.Count
		{
			get
			{
				return default(int);
			}
		}

		object IReadOnlyList.this[int P_0]
		{
			get
			{
				return null;
			}
		}

		public IndexedDictionary()
		{
		}

		public IndexedDictionary(int capacity)
		{
		}

		public IndexedDictionary(bool allowDuplicateKeys)
		{
		}

		public IndexedDictionary(int capacity, bool allowDuplicateKeys)
		{
		}

		public IndexedDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		public IndexedDictionary(IDictionary<TKey, TValue> dictionary, bool allowDuplicateKeys)
		{
		}

		public TValue GetValue(TKey key)
		{
			return (TValue)null;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		public TKey GetKeyAt(int index)
		{
			return (TKey)null;
		}

		public KeyValuePair<TKey, TValue> GetEntry(TKey key)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		public KeyValuePair<TKey, TValue> GetEntryAt(int index)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		public bool TryGetEntry(TKey key, out KeyValuePair<TKey, TValue> entry)
		{
			return default(bool);
		}

		public void Add(TKey key, TValue value)
		{
		}

		public void SetValue(TKey key, TValue value)
		{
		}

		public bool Remove(TKey key)
		{
			return default(bool);
		}

		public void RemoveAt(int index)
		{
		}

		public void RemoveValue(TValue value)
		{
		}

		public int RemoveAll(TValue value)
		{
			return default(int);
		}

		public int IndexOfKey(TKey key)
		{
			return default(int);
		}

		public int IndexOfValue(TValue value)
		{
			return default(int);
		}

		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		public void Clear()
		{
		}

		public void TrimExcess()
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
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

		void ICollection.CopyTo(Array array, int index)
		{
		}

		int Rewired.Utils.Interfaces.IReadOnlyList<TValue>.IndexOf(TValue P_0)
		{
			return default(int);
		}

		bool Rewired.Utils.Interfaces.IReadOnlyList<TValue>.Contains(TValue P_0)
		{
			return default(bool);
		}

		int IReadOnlyList.IndexOf(object P_0)
		{
			return default(int);
		}

		bool IReadOnlyList.Contains(object P_0)
		{
			return default(bool);
		}
	}
}
