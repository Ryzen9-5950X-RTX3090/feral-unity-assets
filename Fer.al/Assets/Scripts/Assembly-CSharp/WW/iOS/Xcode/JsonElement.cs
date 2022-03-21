namespace WW.iOS.Xcode
{
	internal class JsonElement
	{
		public JsonElement this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected JsonElement()
		{
		}

		public string AsString()
		{
			return null;
		}

		public int AsInteger()
		{
			return default(int);
		}

		public bool AsBoolean()
		{
			return default(bool);
		}

		public JsonElementArray AsArray()
		{
			return null;
		}

		public JsonElementDict AsDict()
		{
			return null;
		}
	}
}
