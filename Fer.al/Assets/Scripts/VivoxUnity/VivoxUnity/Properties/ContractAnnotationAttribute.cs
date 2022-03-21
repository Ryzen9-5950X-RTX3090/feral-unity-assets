using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ContractAnnotationAttribute : Attribute
	{
		[NotNull]
		public string Contract
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

		public bool ForceFullStates
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ContractAnnotationAttribute(string contract)
		{
		}

		public ContractAnnotationAttribute(string contract, bool forceFullStates)
		{
		}
	}
}
