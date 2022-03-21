using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AspMvcMasterLocationFormatAttribute : Attribute
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

		public AspMvcMasterLocationFormatAttribute(string format)
		{
		}
	}
}
