using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class RazorDirectiveAttribute : Attribute
	{
		[NotNull]
		public string Directive
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

		public RazorDirectiveAttribute(string directive)
		{
		}
	}
}
