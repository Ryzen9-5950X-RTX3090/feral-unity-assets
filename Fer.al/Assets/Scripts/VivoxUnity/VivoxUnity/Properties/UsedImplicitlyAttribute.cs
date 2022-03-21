using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.All)]
	public sealed class UsedImplicitlyAttribute : Attribute
	{
		public ImplicitUseKindFlags UseKindFlags
		{
			[CompilerGenerated]
			get
			{
				return default(ImplicitUseKindFlags);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ImplicitUseTargetFlags TargetFlags
		{
			[CompilerGenerated]
			get
			{
				return default(ImplicitUseTargetFlags);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public UsedImplicitlyAttribute()
		{
		}

		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
		{
		}

		public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
		{
		}

		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
		}
	}
}
