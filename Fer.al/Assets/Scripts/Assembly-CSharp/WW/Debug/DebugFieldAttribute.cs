using System;

namespace WW.Debug
{
	public class DebugFieldAttribute : Attribute
	{
		private string _name;

		private string _group;

		private bool _readonly;

		private bool _persistent;

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string Group
		{
			get
			{
				return null;
			}
		}

		public bool Readonly
		{
			get
			{
				return default(bool);
			}
		}

		public bool Persistent
		{
			get
			{
				return default(bool);
			}
		}

		public DebugFieldAttribute(string inName = "", string inGroup = "General", bool inReadonly = false, bool inPersistent = false)
		{
		}
	}
}
