using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections
{
	internal class LinkedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private readonly LinkedDictionary parent;

		private int pos;

		public virtual object Current
		{
			get
			{
				return null;
			}
		}

		public virtual DictionaryEntry Entry
		{
			get
			{
				return default(DictionaryEntry);
			}
		}

		public virtual object Key
		{
			get
			{
				return null;
			}
		}

		public virtual object Value
		{
			get
			{
				return null;
			}
		}

		private object CurrentKey
		{
			get
			{
				return null;
			}
		}

		internal LinkedDictionaryEnumerator(LinkedDictionary parent)
		{
		}

		public virtual bool MoveNext()
		{
			return default(bool);
		}

		public virtual void Reset()
		{
		}
	}
}
