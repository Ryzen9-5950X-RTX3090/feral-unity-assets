using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class ValueProviderAttribute : Attribute
	{
		[NotNull]
		public string Name
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

		public ValueProviderAttribute(string name)
		{
		}
	}
}
