using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	public class PlistElementDict : PlistElement
	{
		private SortedDictionary<string, PlistElement> m_PrivateValue;

		public IDictionary<string, PlistElement> values
		{
			get
			{
				return null;
			}
		}

		public new PlistElement this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
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

		public PlistElementArray CreateArray(string key)
		{
			return null;
		}

		public PlistElementDict CreateDict(string key)
		{
			return null;
		}
	}
}
