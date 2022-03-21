using System;
using System.Runtime.CompilerServices;

namespace SQLite4Unity3d
{
	[AttributeUsage(AttributeTargets.Property)]
	public class MaxLengthAttribute : Attribute
	{
		public int Value
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MaxLengthAttribute(int length)
		{
		}
	}
}
