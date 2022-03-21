using System.Collections.Generic;

namespace WW.iOS.Xcode.PBX
{
	internal class BuildConfigEntryData
	{
		public string name;

		public List<string> val;

		public static string ExtractValue(string src)
		{
			return null;
		}

		public void AddValue(string value)
		{
		}

		public void RemoveValue(string value)
		{
		}

		public void RemoveValueList(IEnumerable<string> values)
		{
		}

		public static BuildConfigEntryData FromNameValue(string name, string value)
		{
			return null;
		}
	}
}
