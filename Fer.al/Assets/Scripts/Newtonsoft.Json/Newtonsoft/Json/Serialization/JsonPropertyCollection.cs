using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Newtonsoft.Json.Serialization
{
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		private readonly Type _type;

		private readonly List<JsonProperty> _list;

		public JsonPropertyCollection(Type type)
		{
		}

		protected override string GetKeyForItem(JsonProperty item)
		{
			return null;
		}

		public void AddProperty(JsonProperty property)
		{
		}

		public JsonProperty GetClosestMatchProperty(string propertyName)
		{
			return null;
		}

		private bool TryGetValue(string key, out JsonProperty item)
		{
			return default(bool);
		}

		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			return null;
		}
	}
}
