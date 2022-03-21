using System.Collections.Generic;

namespace WW.iOS.Xcode.PBX
{
	internal class XCBuildConfigurationData : PBXObjectData
	{
		protected SortedDictionary<string, BuildConfigEntryData> entries;

		public string baseConfigurationReference;

		public string name
		{
			get
			{
				return null;
			}
		}

		private static string EscapeWithQuotesIfNeeded(string name, string value)
		{
			return null;
		}

		public void SetProperty(string name, string value)
		{
		}

		public void AddProperty(string name, string value)
		{
		}

		public void RemoveProperty(string name)
		{
		}

		public void RemovePropertyValue(string name, string value)
		{
		}

		public void RemovePropertyValueList(string name, IEnumerable<string> valueList)
		{
		}

		public static XCBuildConfigurationData Create(string name)
		{
			return null;
		}

		public override void UpdateProps()
		{
		}

		public override void UpdateVars()
		{
		}
	}
}
