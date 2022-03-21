using System;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
	public sealed class ProvidesContextAttribute : Attribute
	{
	}
}
