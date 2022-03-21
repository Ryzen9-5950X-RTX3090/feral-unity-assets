using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class AWSPropertyAttribute : Attribute
	{
		private long min;

		private long max;

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

		public bool IsMinSet
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

		public long Min
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public bool IsMaxSet
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

		public long Max
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
	}
}
