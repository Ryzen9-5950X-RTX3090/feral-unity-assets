using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		[UsedImplicitly]
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

		[UsedImplicitly]
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

		public MeansImplicitUseAttribute()
		{
		}

		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
		{
		}

		public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
		{
		}

		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
		}
	}
}
