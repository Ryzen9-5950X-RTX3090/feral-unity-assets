using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-piglet")]
	public abstract class AtomList<T, E> : BaseAtomList, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable where E : AtomEvent<T>
	{
		public E Added;

		public E Removed;

		[SerializeField]
		private List<T> list;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		public List<T> List
		{
			get
			{
				return null;
			}
			set
			{
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

		protected override IList IList
		{
			get
			{
				return null;
			}
		}

		public void Add(T item)
		{
		}

		public bool Remove(T item)
		{
			return default(bool);
		}

		public bool Contains(T item)
		{
			return default(bool);
		}

		public T Get(int i)
		{
			return (T)null;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		public int IndexOf(T item)
		{
			return default(int);
		}

		public void RemoveAt(int index)
		{
		}

		public void Insert(int index, T item)
		{
		}

		public IObservable<T> ObserveAdd()
		{
			return null;
		}

		public IObservable<T> ObserveRemove()
		{
			return null;
		}

		public IObservable<Void> ObserveClear()
		{
			return null;
		}
	}
}
