using System;
using System.Collections.Generic;

namespace ParadoxNotion
{
	public class WeakReferenceList<T> where T : class
	{
		private List<WeakReference<T>> list;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public T this[int i]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public WeakReferenceList()
		{
		}

		public WeakReferenceList(int capacity)
		{
		}

		public void Add(T item)
		{
		}

		public void Remove(T item)
		{
		}

		public bool Contains(T item, out int index)
		{
			return default(bool);
		}

		public void Clear()
		{
		}

		public List<T> ToReferenceList()
		{
			return null;
		}

		public static implicit operator WeakReferenceList<T>(List<T> value)
		{
			return null;
		}
	}
}
