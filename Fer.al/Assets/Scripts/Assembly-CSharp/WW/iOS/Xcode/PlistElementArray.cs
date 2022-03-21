using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	public class PlistElementArray : PlistElement
	{
		public List<PlistElement> values;

		public void AddString(string val)
		{
		}

		public void AddInteger(int val)
		{
		}

		public void AddBoolean(bool val)
		{
		}

		public PlistElementArray AddArray()
		{
			return null;
		}

		public PlistElementDict AddDict()
		{
			return null;
		}
	}
}
