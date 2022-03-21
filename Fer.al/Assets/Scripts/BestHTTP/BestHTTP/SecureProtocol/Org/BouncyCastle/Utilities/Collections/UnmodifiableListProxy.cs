using System;
using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
{
	public class UnmodifiableListProxy : UnmodifiableList
	{
		private readonly IList l;

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

		public UnmodifiableListProxy(IList l)
		{
		}

		public override bool Contains(object o)
		{
			return default(bool);
		}

		public override void CopyTo(Array array, int index)
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		public override int IndexOf(object o)
		{
			return default(int);
		}

		protected override object GetValue(int i)
		{
			return null;
		}
	}
}
