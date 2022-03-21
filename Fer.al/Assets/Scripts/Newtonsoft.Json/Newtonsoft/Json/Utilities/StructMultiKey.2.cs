using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	[IsReadOnly]
	internal struct StructMultiKey<T1, T2> : IEquatable<StructMultiKey<T1, T2>>
	{
		public readonly T1 Value1;

		public readonly T2 Value2;

		public StructMultiKey(T1 v1, T2 v2)
		{
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(StructMultiKey<T1, T2> other)
		{
			return default(bool);
		}
	}
}
