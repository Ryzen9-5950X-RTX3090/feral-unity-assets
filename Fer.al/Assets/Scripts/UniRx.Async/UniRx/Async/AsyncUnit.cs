using System;
using System.Runtime.InteropServices;

namespace UniRx.Async
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct AsyncUnit : IEquatable<AsyncUnit>
	{
		public static readonly AsyncUnit Default;

		public override int GetHashCode()
		{
			return default(int);
		}

		public bool Equals(AsyncUnit other)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
