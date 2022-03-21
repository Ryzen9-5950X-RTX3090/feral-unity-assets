using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter)]
	public sealed class JsonConverterAttribute : Attribute
	{
		private readonly Type _converterType;

		[CompilerGenerated]
		private readonly object[] <ConverterParameters>k__BackingField;

		public Type ConverterType
		{
			get
			{
				return null;
			}
		}

		public object[] ConverterParameters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
