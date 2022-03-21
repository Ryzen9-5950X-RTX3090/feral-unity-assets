using System;
using System.Runtime.CompilerServices;

namespace BestHTTP.PlatformSupport.IL2CPP
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
	public class Il2CppSetOptionAttribute : Attribute
	{
		public Option Option
		{
			[CompilerGenerated]
			get
			{
				return default(Option);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public object Value
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

		public Il2CppSetOptionAttribute(Option option, object value)
		{
		}
	}
}
