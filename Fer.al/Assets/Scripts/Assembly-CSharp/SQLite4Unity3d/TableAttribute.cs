using System;
using System.Runtime.CompilerServices;

namespace SQLite4Unity3d
{
	[AttributeUsage(AttributeTargets.Class)]
	public class TableAttribute : Attribute
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

		public TableAttribute(string name)
		{
		}
	}
}
