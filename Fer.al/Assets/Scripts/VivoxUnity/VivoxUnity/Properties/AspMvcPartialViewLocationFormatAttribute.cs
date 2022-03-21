using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AspMvcPartialViewLocationFormatAttribute : Attribute
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

		public AspMvcPartialViewLocationFormatAttribute(string format)
		{
		}
	}
}
