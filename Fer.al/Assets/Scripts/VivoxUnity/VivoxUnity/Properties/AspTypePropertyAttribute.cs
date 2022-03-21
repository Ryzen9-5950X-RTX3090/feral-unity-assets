using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class AspTypePropertyAttribute : Attribute
	{
		public bool CreateConstructorReferences
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AspTypePropertyAttribute(bool createConstructorReferences)
		{
		}
	}
}
