using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
	{
		[NotNull]
		public string Format
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

		public AspMvcAreaMasterLocationFormatAttribute(string format)
		{
		}
	}
}
