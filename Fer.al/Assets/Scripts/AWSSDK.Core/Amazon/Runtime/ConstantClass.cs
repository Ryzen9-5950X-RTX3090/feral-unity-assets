using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public class ConstantClass
	{
		private static readonly object staticFieldsLock;

		private static Dictionary<Type, Dictionary<string, ConstantClass>> staticFields;

		public string Value
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected ConstantClass(string value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public static implicit operator string(ConstantClass value)
		{
			return null;
		}

		internal ConstantClass Intern()
		{
			return null;
		}

		protected static T FindValue<T>(string value) where T : ConstantClass
		{
			return null;
		}

		private static void LoadFields(Type t)
		{
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public virtual bool Equals(ConstantClass obj)
		{
			return default(bool);
		}

		protected virtual bool Equals(string value)
		{
			return default(bool);
		}

		public static bool operator ==(ConstantClass a, ConstantClass b)
		{
			return default(bool);
		}

		public static bool operator !=(ConstantClass a, ConstantClass b)
		{
			return default(bool);
		}

		public static bool operator ==(ConstantClass a, string b)
		{
			return default(bool);
		}

		public static bool operator ==(string a, ConstantClass b)
		{
			return default(bool);
		}

		public static bool operator !=(ConstantClass a, string b)
		{
			return default(bool);
		}

		public static bool operator !=(string a, ConstantClass b)
		{
			return default(bool);
		}
	}
}
