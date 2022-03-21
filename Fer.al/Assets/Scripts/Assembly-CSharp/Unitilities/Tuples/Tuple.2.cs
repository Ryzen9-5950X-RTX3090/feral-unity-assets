using System;
using System.Collections.Generic;

namespace Unitilities.Tuples
{
	[Serializable]
	public class Tuple<T1, T2>
	{
		public T1 first;

		public T2 second;

		private static readonly IEqualityComparer<T1> Item1Comparer;

		private static readonly IEqualityComparer<T2> Item2Comparer;

		public Tuple(T1 _first, T2 _second)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		private static bool IsNull(object obj)
		{
			return default(bool);
		}

		public static bool operator ==(Tuple<T1, T2> a, Tuple<T1, T2> b)
		{
			return default(bool);
		}

		public static bool operator !=(Tuple<T1, T2> a, Tuple<T1, T2> b)
		{
			return default(bool);
		}
	}
}
