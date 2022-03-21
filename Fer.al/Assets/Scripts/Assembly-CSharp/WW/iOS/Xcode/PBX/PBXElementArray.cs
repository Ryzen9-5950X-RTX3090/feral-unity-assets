using System.Collections.Generic;

namespace WW.iOS.Xcode.PBX
{
	internal class PBXElementArray : PBXElement
	{
		public List<PBXElement> values;

		public void AddString(string val)
		{
		}

		public PBXElementArray AddArray()
		{
			return null;
		}

		public PBXElementDict AddDict()
		{
			return null;
		}
	}
}
