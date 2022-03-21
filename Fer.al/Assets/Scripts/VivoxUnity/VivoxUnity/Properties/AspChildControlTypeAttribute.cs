using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class AspChildControlTypeAttribute : Attribute
	{
		[NotNull]
		public string TagName
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

		[NotNull]
		public Type ControlType
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

		public AspChildControlTypeAttribute(string tagName, Type controlType)
		{
		}
	}
}
