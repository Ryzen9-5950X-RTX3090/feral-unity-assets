using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class AspRequiredAttributeAttribute : Attribute
	{
		[NotNull]
		public string Attribute
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

		public AspRequiredAttributeAttribute(string attribute)
		{
		}
	}
}
