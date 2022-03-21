using System;
using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
{
	public class UnmodifiableSetProxy : UnmodifiableSet
	{
		private readonly ISet s;

		public override int Count
		{
			get
			{
				return default(int);
			}
		}

		public override bool IsEmpty
		{
			get
			{
				return default(bool);
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

		public UnmodifiableSetProxy(ISet s)
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
	}
}
