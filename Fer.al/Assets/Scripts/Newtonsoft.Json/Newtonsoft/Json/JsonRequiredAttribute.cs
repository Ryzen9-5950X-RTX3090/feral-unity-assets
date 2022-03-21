using System;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class JsonRequiredAttribute : Attribute
	{
	}
}
