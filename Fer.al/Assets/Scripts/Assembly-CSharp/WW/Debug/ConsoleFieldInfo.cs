using System;
using System.Reflection;

namespace WW.Debug
{
	public class ConsoleFieldInfo
	{
		private FieldInfo _field;

		private PropertyInfo _property;

		private string _name;

		private string _group;

		private object _instance;

		private bool _readonly;

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

		public object Instance
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

		public Type Type
		{
			get
			{
				return null;
			}
		}

		public object GetValue()
		{
			return null;
		}

		public void SetValue(object inValue)
		{
		}

		public ConsoleFieldInfo(FieldInfo inField, object inInstance, string inName, string inGroup, bool inReadonly)
		{
		}

		public ConsoleFieldInfo(PropertyInfo inProperty, object inInstance, string inName, string inGroup, bool inReadonly)
		{
		}
	}
}
