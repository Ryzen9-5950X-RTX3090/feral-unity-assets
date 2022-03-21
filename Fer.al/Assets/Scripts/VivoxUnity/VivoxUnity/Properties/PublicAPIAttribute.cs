using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[MeansImplicitUse]
	public sealed class PublicAPIAttribute : Attribute
	{
		[CanBeNull]
		public string Comment
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

		public PublicAPIAttribute()
		{
		}

		public PublicAPIAttribute(string comment)
		{
		}
	}
}
