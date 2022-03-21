using System.Collections;
using System.Collections.Generic;

namespace Amazon.Runtime.Internal
{
	public class ParametersDictionaryFacade : IDictionary<string, string>, ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		private readonly ParameterCollection _parameterCollection;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public string this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ICollection<string> Keys
		{
			get
			{
				return null;
			}
		}

		public ICollection<string> Values
		{
			get
			{
				return null;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		public ParametersDictionaryFacade(ParameterCollection collection)
		{
		}

		private static string ParameterValueToString(ParameterValue pv)
		{
			return null;
		}

		private static void UpdateParameterValue(ParameterValue pv, string newValue)
		{
		}

		public void Add(string key, string value)
		{
		}

		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		public bool Remove(string key)
		{
			return default(bool);
		}

		public bool TryGetValue(string key, out string value)
		{
			return default(bool);
		}

		public bool Remove(KeyValuePair<string, string> item)
		{
			return default(bool);
		}

		public void Add(KeyValuePair<string, string> item)
		{
		}

		public bool Contains(KeyValuePair<string, string> item)
		{
			return default(bool);
		}

		public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
		{
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
