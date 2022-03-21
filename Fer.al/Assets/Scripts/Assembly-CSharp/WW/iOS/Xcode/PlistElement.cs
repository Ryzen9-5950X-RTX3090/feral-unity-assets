namespace WW.iOS.Xcode
{
	public class PlistElement
	{
		public PlistElement this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected PlistElement()
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

		public PlistElementArray AsArray()
		{
			return null;
		}

		public PlistElementDict AsDict()
		{
			return null;
		}
	}
}
