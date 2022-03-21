using System;
using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
{
	public class LinkedDictionary : IDictionary, ICollection, IEnumerable
	{
		internal readonly IDictionary hash;

		internal readonly IList keys;

		public virtual int Count
		{
			get
			{
				return default(int);
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

		public virtual ICollection Keys
		{
			get
			{
				return null;
			}
		}

		public virtual ICollection Values
		{
			get
			{
				return null;
			}
		}

		public virtual object this[object k]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual void Add(object k, object v)
		{
		}

		public virtual void Clear()
		{
		}

		public virtual bool Contains(object k)
		{
			return default(bool);
		}

		public virtual void CopyTo(Array array, int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		public virtual void Remove(object k)
		{
		}
	}
}
