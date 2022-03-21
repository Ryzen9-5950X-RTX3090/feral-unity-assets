using System;

namespace Rewired.Utils.Libraries.TinyJson
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class SerializeAttribute : Attribute
	{
		public string Name;
	}
}
