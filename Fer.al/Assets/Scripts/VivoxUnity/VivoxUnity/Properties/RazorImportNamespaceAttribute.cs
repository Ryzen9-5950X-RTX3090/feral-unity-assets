using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class RazorImportNamespaceAttribute : Attribute
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

		public RazorImportNamespaceAttribute(string name)
		{
		}
	}
}
