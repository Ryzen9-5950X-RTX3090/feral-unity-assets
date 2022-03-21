using System;

namespace Gaia.FullSerializer
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class fsPropertyAttribute : Attribute
	{
		public string Name;

		public fsPropertyAttribute()
		{
		}

		public fsPropertyAttribute(string name)
		{
		}
	}
}
