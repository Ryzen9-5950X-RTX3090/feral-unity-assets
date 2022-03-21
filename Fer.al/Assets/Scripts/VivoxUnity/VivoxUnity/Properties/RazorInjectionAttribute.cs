using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class RazorInjectionAttribute : Attribute
	{
		[NotNull]
		public string Type
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
		public string FieldName
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

		public RazorInjectionAttribute(string type, string fieldName)
		{
		}
	}
}
