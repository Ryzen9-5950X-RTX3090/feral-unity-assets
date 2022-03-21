using System;
using System.Runtime.CompilerServices;

namespace SQLite4Unity3d
{
	[AttributeUsage(AttributeTargets.Property)]
	public class ColumnAttribute : Attribute
	{
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ColumnAttribute(string name)
		{
		}
	}
}
