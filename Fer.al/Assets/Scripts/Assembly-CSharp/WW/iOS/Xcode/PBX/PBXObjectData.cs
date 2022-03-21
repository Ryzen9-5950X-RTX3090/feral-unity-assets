using System.Collections.Generic;

namespace WW.iOS.Xcode.PBX
{
	internal class PBXObjectData
	{
		public string guid;

		protected PBXElementDict m_Properties;

		private static PropertyCommentChecker checkerData;

		internal virtual PropertyCommentChecker checker
		{
			get
			{
				return null;
			}
		}

		internal virtual bool shouldCompact
		{
			get
			{
				return default(bool);
			}
		}

		internal void SetPropertiesWhenSerializing(PBXElementDict props)
		{
		}

		internal PBXElementDict GetPropertiesWhenSerializing()
		{
			return null;
		}

		internal PBXElementDict GetPropertiesRaw()
		{
			return null;
		}

		protected string GetPropertyString(string name)
		{
			return null;
		}

		protected void SetPropertyString(string name, string value)
		{
		}

		protected List<string> GetPropertyList(string name)
		{
			return null;
		}

		protected void SetPropertyList(string name, List<string> value)
		{
		}

		public virtual void UpdateProps()
		{
		}

		public virtual void UpdateVars()
		{
		}
	}
}
