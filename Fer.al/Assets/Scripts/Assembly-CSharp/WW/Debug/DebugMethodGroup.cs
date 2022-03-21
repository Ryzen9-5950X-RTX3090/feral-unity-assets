using System.Collections.Generic;

namespace WW.Debug
{
	public class DebugMethodGroup
	{
		private string _name;

		private string _path;

		public List<ConsoleMethodInfo> methods;

		public List<ConsoleFieldInfo> fields;

		public List<DebugMethodGroup> subGroups;

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string Path
		{
			get
			{
				return null;
			}
		}

		public DebugMethodGroup(string inName, string inPath)
		{
		}

		public DebugMethodGroup GetSubGroup(string[] inGroupPath, int inStartIndex, bool inCreateIfNeeded)
		{
			return null;
		}
	}
}
