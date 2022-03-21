using System;
using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
{
	public class UnmodifiableDictionaryProxy : UnmodifiableDictionary
	{
		private readonly IDictionary d;

		public override int Count
		{
			get
			{
				return default(int);
			}
		}

		public override bool IsFixedSize
		{
			get
			{
				return default(bool);
			}
		}

		public override bool IsSynchronized
		{
			get
			{
				return default(bool);
			}
		}

		public override object SyncRoot
		{
			get
			{
				return null;
			}
		}

		public override ICollection Keys
		{
			get
			{
				return null;
			}
		}

		public override ICollection Values
		{
			get
			{
				return null;
			}
		}

		public UnmodifiableDictionaryProxy(IDictionary d)
		{
		}

		public override bool Contains(object k)
		{
			return default(bool);
		}

		public override void CopyTo(Array array, int index)
		{
		}

		public override IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		protected override object GetValue(object k)
		{
			return null;
		}
	}
}
