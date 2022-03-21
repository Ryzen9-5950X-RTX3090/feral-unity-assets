using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity
{
	public sealed class ValueEventArg<TK, TV> : EventArgs
	{
		public TK Key
		{
			[CompilerGenerated]
			get
			{
				return (TK)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TV Value
		{
			[CompilerGenerated]
			get
			{
				return (TV)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string PropertyName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ValueEventArg(TK key, TV value, string name)
		{
		}
	}
}
