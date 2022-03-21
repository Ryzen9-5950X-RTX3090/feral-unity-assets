using System;
using System.Runtime.CompilerServices;

namespace ThirdParty.Json.LitJson
{
	[AttributeUsage(AttributeTargets.Property)]
	public class JsonPropertyAttribute : Attribute
	{
		public bool Required
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
