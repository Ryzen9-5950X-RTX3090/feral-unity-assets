using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AspMvcAreaPartialViewLocationFormatAttribute : Attribute
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

		public AspMvcAreaPartialViewLocationFormatAttribute(string format)
		{
		}
	}
}
