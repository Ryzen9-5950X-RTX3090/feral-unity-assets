using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity
{
	public sealed class KeyEventArg<TK> : EventArgs
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

		public KeyEventArg(TK key)
		{
		}
	}
}
