using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class MustUseReturnValueAttribute : Attribute
	{
		[CanBeNull]
		public string Justification
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

		public MustUseReturnValueAttribute()
		{
		}

		public MustUseReturnValueAttribute(string justification)
		{
		}
	}
}
