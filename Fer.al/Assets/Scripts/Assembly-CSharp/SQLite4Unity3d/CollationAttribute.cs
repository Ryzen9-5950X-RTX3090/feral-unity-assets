using System;
using System.Runtime.CompilerServices;

namespace SQLite4Unity3d
{
	[AttributeUsage(AttributeTargets.Property)]
	public class CollationAttribute : Attribute
	{
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

		public CollationAttribute(string collation)
		{
		}
	}
}
