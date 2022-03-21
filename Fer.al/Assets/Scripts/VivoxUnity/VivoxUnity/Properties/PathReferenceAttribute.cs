using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class PathReferenceAttribute : Attribute
	{
		[CanBeNull]
		public string BasePath
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

		public PathReferenceAttribute()
		{
		}

		public PathReferenceAttribute(string basePath)
		{
		}
	}
}
