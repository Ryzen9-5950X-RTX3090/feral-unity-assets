using System;
using System.Collections;

namespace PlatformSupport.Collections.Specialized
{
	internal sealed class ReadOnlyList : IList, ICollection, IEnumerable
	{
		private readonly IList _list;

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

		public bool IsFixedSize
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsSynchronized
		{
			get
			{
				return default(bool);
			}
		}

		public object this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		internal ReadOnlyList(IList list)
		{
		}

		public int Add(object value)
		{
			return default(int);
		}

		public void Clear()
		{
		}

		public bool Contains(object value)
		{
			return default(bool);
		}

		public void CopyTo(Array array, int index)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public int IndexOf(object value)
		{
			return default(int);
		}

		public void Insert(int index, object value)
		{
		}

		public void Remove(object value)
		{
		}

		public void RemoveAt(int index)
		{
		}
	}
}
