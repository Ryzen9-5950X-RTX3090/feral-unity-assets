using System.Collections.Generic;

namespace WW.iOS.Xcode.PBX
{
	internal class PBXElementDict : PBXElement
	{
		private Dictionary<string, PBXElement> m_PrivateValue;

		public IDictionary<string, PBXElement> values
		{
			get
			{
				return null;
			}
		}

		public new PBXElement this[string key]
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

		public void SetString(string key, string val)
		{
		}

		public PBXElementArray CreateArray(string key)
		{
			return null;
		}

		public PBXElementDict CreateDict(string key)
		{
			return null;
		}
	}
}
