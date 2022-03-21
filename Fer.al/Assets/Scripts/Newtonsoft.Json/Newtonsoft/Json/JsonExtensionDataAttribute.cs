using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class JsonExtensionDataAttribute : Attribute
	{
		[CompilerGenerated]
		private bool <WriteData>k__BackingField;

		[CompilerGenerated]
		private bool <ReadData>k__BackingField;

		public bool WriteData
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		public bool ReadData
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}
	}
}
