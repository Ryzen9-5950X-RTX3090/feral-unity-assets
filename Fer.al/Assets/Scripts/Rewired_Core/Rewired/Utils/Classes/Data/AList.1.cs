using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class AList<T> : IList, IEnumerable, ICollection, IEnumerable<T>, ICollection<T>, IList<T>
	{
		[Serializable]
		public struct skKzdUZbYBEBxZqKQKAIgzFPcIt : IDisposable, IEnumerator, IEnumerator<T>
		{
			private AList<T> list;

			private int index;

			private int version;

			private T current;

			public T iqRXBCFJzSXINtBNEmUcRPMPsKE
			{
				get
				{
					return (T)null;
				}
			}

			object IEnumerator.lEHmhZcDVBCvVkmanIeFkjDMVct
			{
				get
				{
					return null;
				}
			}

			internal skKzdUZbYBEBxZqKQKAIgzFPcIt(AList<T> list)
			{
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			private bool mGRuCjPDMbxAnMBLgXgjddgPkSL()
			{
				return default(bool);
			}

			void IEnumerator.Reset()
			{
			}
		}

		private const int SFatwjibynXGEomWOnOKTtIVggf = 4;

		private static readonly T[] EmpnQqFSmctMRvSIhWrQSbIUrQJ;

		private IEqualityComparer<T> BpqgKwtwxiCJWBlAQLLFXpVLOJgD;

		public T[] _items;

		private int LHcUXOytTkIjlqPoenVhkyCFGKR;

		public int _count;

		private int JcItYmplPOUuUXgZFGENZdovpnY;

		private bool WWdbcyRFlTeBVkzHnYfpEPbdVyg;

		private readonly int OoGlvnFCRjGSzsoWBBLcZxoAxKx;

		private readonly bool aIIxLBxcYMhlGvgopclnroCYGOX;

		private int wNPCYmLfYxcqAQsDPfNrFaPUdXp;

		[NonSerialized]
		private object vYiBUIHFosLSVhIQAioByfsCKmi;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public int Capacity
		{
			get
			{
				return default(int);
			}
		}

		public int FreeSpace
		{
			get
			{
				return default(int);
			}
		}

		public bool IsFixedSize
		{
			get
			{
				return default(bool);
			}
		}

		public IEqualityComparer<T> EqualityComparer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Version
		{
			get
			{
				return default(int);
			}
		}

		public T this[int index]
		{
			get
			{
				return (T)null;
			}
			set
			{
			}
		}

		bool ICollection<T>.IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		bool IList.IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		int ICollection.Count
		{
			get
			{
				return default(int);
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

		public AList()
		{
		}

		public AList(int startingCapacity)
		{
		}

		public AList(int startingCapacity, int maxCapacity)
		{
		}

		public AList(int startingCapacity, int maxCapacity, int expansionIncrement)
		{
		}

		public AList(IEnumerable<T> collection)
		{
		}

		public AList(IEnumerable<T> collection, int maxCapacity, int expansionIncrement)
		{
		}

		public T GetRandom()
		{
			return (T)null;
		}

		public int Add(T item)
		{
			return default(int);
		}

		public bool Add(T[] items, int count = 0, int startIndex = 0, bool allowPartialAdd = false)
		{
			return default(bool);
		}

		public bool Add(AList<T> items, int count = 0, int startIndex = 0, bool allowPartialAdd = false)
		{
			return default(bool);
		}

		public int AddIfUnique(T item)
		{
			return default(int);
		}

		public int AddToFirstOpenSpace(T item)
		{
			return default(int);
		}

		public int AddToFirstOpenSpace(T item, T openSpaceEquals)
		{
			return default(int);
		}

		public bool Insert(int index, T item)
		{
			return default(bool);
		}

		public bool Remove(T item)
		{
			return default(bool);
		}

		public void RemoveAt(int index)
		{
		}

		public bool Contains(T item)
		{
			return default(bool);
		}

		public bool Contains(T item, IEqualityComparer<T> comparer)
		{
			return default(bool);
		}

		public int IndexOf(T item)
		{
			return default(int);
		}

		public int IndexOf(T item, int index)
		{
			return default(int);
		}

		public int IndexOf(T item, int index, int count)
		{
			return default(int);
		}

		public int IndexOf(T item, IEqualityComparer<T> comparer)
		{
			return default(int);
		}

		public int IndexOf(T item, int index, IEqualityComparer<T> comparer)
		{
			return default(int);
		}

		public int IndexOf(T item, int index, int count, IEqualityComparer<T> comparer)
		{
			return default(int);
		}

		public void Reverse()
		{
		}

		public void Reverse(int index, int count)
		{
		}

		public void Sort()
		{
		}

		public void Sort(IComparer<T> comparer)
		{
		}

		public void Sort(int index, int count, IComparer<T> comparer)
		{
		}

		public List<T> GetRange(int index, int count)
		{
			return null;
		}

		public ReadOnlyCollection<T> AsReadOnly()
		{
			return null;
		}

		public bool Exists(Predicate<T> match)
		{
			return default(bool);
		}

		public T Find(Predicate<T> match)
		{
			return (T)null;
		}

		public List<T> FindAll(Predicate<T> match)
		{
			return null;
		}

		public int FindIndex(Predicate<T> match)
		{
			return default(int);
		}

		public int FindIndex(int startIndex, Predicate<T> match)
		{
			return default(int);
		}

		public int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			return default(int);
		}

		public T FindLast(Predicate<T> match)
		{
			return (T)null;
		}

		public int FindLastIndex(Predicate<T> match)
		{
			return default(int);
		}

		public int FindLastIndex(int startIndex, Predicate<T> match)
		{
			return default(int);
		}

		public int FindLastIndex(int startIndex, int count, Predicate<T> match)
		{
			return default(int);
		}

		public void ForEach(Action<T> action)
		{
		}

		public int LastIndexOf(T item)
		{
			return default(int);
		}

		public int LastIndexOf(T item, int index)
		{
			return default(int);
		}

		public int LastIndexOf(T item, int index, int count)
		{
			return default(int);
		}

		public int RemoveAll(Predicate<T> match)
		{
			return default(int);
		}

		public bool TrueForAll(Predicate<T> match)
		{
			return default(bool);
		}

		public T[] ToArray()
		{
			return null;
		}

		public void CopyTo(int index, T[] array, int arrayIndex, int count)
		{
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public void Clear()
		{
		}

		public void TrimExcess()
		{
		}

		private int KYhcXjRTztAqPRAJgphDPJVmzZt(int P_0, bool P_1 = false)
		{
			return default(int);
		}

		private int KuuXFaPZEHiivZPFizEBZKcqAZe(int P_0, int P_1)
		{
			return default(int);
		}

		private bool UGfPaKfKAIAknjNVXFiWfAahWzU(int P_0, bool P_1 = false)
		{
			return default(bool);
		}

		void IList<T>.Insert(int index, T item)
		{
		}

		void ICollection<T>.Add(T item)
		{
		}

		void ICollection<T>.CopyTo(T[] array, int arrayIndex)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		int IList.Add(object value)
		{
			return default(int);
		}

		bool IList.Contains(object value)
		{
			return default(bool);
		}

		int IList.IndexOf(object value)
		{
			return default(int);
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		public static AList<T> CreateFixedLengthList(int capacity)
		{
			return null;
		}

		private static bool yMMYzBSOYmQjMegUabqvdRTfDWfl(object P_0)
		{
			return default(bool);
		}
	}
}
