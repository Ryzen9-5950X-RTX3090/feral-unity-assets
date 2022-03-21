using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Newtonsoft.Json.Linq
{
	[DefaultMember("Item")]
	internal class JPropertyKeyedCollection : Collection<JToken>
	{
		private static readonly IEqualityComparer<string> Comparer;

		private Dictionary<string, JToken> _dictionary;

		public ICollection<string> Keys
		{
			get
			{
				return null;
			}
		}

		private void AddKey(string key, JToken item)
		{
		}

		protected override void ClearItems()
		{
		}

		public bool Contains(string key)
		{
			return default(bool);
		}

		private void EnsureDictionary()
		{
		}

		private string GetKeyForItem(JToken item)
		{
			return null;
		}

		protected override void InsertItem(int index, JToken item)
		{
		}

		protected override void RemoveItem(int index)
		{
		}

		private void RemoveKey(string key)
		{
		}

		protected override void SetItem(int index, JToken item)
		{
		}

		public bool TryGetValue(string key, out JToken value)
		{
			return default(bool);
		}

		public int IndexOfReference(JToken t)
		{
			return default(int);
		}
	}
}
