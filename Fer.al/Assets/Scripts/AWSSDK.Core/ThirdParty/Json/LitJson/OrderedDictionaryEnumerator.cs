using System.Collections;
using System.Collections.Generic;

namespace ThirdParty.Json.LitJson
{
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;

		public object Current
		{
			get
			{
				return null;
			}
		}

		public DictionaryEntry Entry
		{
			get
			{
				return default(DictionaryEntry);
			}
		}

		public object Key
		{
			get
			{
				return null;
			}
		}

		public object Value
		{
			get
			{
				return null;
			}
		}

		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
		}

		public bool MoveNext()
		{
			return default(bool);
		}

		public void Reset()
		{
		}
	}
}
