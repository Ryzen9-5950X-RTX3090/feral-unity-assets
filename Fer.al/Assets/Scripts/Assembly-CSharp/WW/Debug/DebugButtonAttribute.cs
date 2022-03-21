using System;

namespace WW.Debug
{
	[AttributeUsage(AttributeTargets.Method)]
	public class DebugButtonAttribute : Attribute
	{
		private string _name;

		private string _group;

		private bool _persistent;

		private bool _closeOnClick;

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

		public bool Persistent
		{
			get
			{
				return default(bool);
			}
		}

		public bool CloseOnClick
		{
			get
			{
				return default(bool);
			}
		}

		public DebugButtonAttribute(string inName, string inGroup = "General", bool inPersistent = false, bool inCloseOnClick = false)
		{
		}
	}
}
