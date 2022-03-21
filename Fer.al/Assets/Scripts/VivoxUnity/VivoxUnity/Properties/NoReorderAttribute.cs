using System;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	public sealed class NoReorderAttribute : Attribute
	{
	}
}
