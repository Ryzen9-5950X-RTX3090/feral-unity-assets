using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	internal class JsonElementArray : JsonElement
	{
		public List<JsonElement> values;

		public void AddString(string val)
		{
		}

		public void AddInteger(int val)
		{
		}

		public void AddBoolean(bool val)
		{
		}

		public JsonElementArray AddArray()
		{
			return null;
		}

		public JsonElementDict AddDict()
		{
			return null;
		}
	}
}
