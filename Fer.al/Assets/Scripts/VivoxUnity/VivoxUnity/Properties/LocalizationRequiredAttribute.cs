using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class LocalizationRequiredAttribute : Attribute
	{
		public bool Required
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

		public LocalizationRequiredAttribute()
		{
		}

		public LocalizationRequiredAttribute(bool required)
		{
		}
	}
}
