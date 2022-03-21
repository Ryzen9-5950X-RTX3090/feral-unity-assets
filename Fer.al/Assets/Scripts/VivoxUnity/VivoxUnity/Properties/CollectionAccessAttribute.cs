using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Properties
{
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class CollectionAccessAttribute : Attribute
	{
		public CollectionAccessType CollectionAccessType
		{
			[CompilerGenerated]
			get
			{
				return default(CollectionAccessType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
		{
		}
	}
}
