using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	internal class JsonElementDict : JsonElement
	{
		private SortedDictionary<string, JsonElement> m_PrivateValue;

		public IDictionary<string, JsonElement> values
		{
			get
			{
				return null;
			}
		}

		public new JsonElement this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Contains(string key)
		{
			return default(bool);
		}

		public void Remove(string key)
		{
		}

		public void SetInteger(string key, int val)
		{
		}

		public void SetString(string key, string val)
		{
		}

		public void SetBoolean(string key, bool val)
		{
		}

		public JsonElementArray CreateArray(string key)
		{
			return null;
		}

		public JsonElementDict CreateDict(string key)
		{
			return null;
		}
	}
}
