using System;
using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
{
	public class HashSet : ISet, ICollection, IEnumerable
	{
		private readonly IDictionary impl;

		public virtual int Count
		{
			get
			{
				return default(int);
			}
		}

		public virtual bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsFixedSize
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsSynchronized
		{
			get
			{
				return default(bool);
			}
		}

		public virtual object SyncRoot
		{
			get
			{
				return null;
			}
		}

		public HashSet()
		{
		}

		public HashSet(IEnumerable s)
		{
		}

		public virtual void Add(object o)
		{
		}

		public virtual void AddAll(IEnumerable e)
		{
		}

		public virtual void Clear()
		{
		}

		public virtual bool Contains(object o)
		{
			return default(bool);
		}

		public virtual void CopyTo(Array array, int index)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		public virtual void Remove(object o)
		{
		}

		public virtual void RemoveAll(IEnumerable e)
		{
		}
	}
}
