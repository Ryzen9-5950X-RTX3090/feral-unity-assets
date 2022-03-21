using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AssertionConditionAttribute : Attribute
	{
		public AssertionConditionType ConditionType
		{
			[CompilerGenerated]
			get
			{
				return default(AssertionConditionType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AssertionConditionAttribute(AssertionConditionType conditionType)
		{
		}
	}
}
