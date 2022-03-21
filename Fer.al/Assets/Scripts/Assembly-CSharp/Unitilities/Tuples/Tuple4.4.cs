using System;
using System.Collections.Generic;

namespace Unitilities.Tuples
{
	[Serializable]
	public class Tuple4<T1, T2, T3, T4>
	{
		public T1 first;

		public T2 second;

		public T3 third;

		public T4 fourth;

		private static readonly IEqualityComparer<T1> Item1Comparer;

		private static readonly IEqualityComparer<T2> Item2Comparer;

		private static readonly IEqualityComparer<T3> Item3Comparer;

		private static readonly IEqualityComparer<T4> Item4Comparer;

		public Tuple4(Tuple<T1, T2> _tuple2, T3 _third, T4 _fourth)
		{
		}

		public Tuple4(Tuple3<T1, T2, T3> _tuple3, T4 _fourth)
		{
		}

		public Tuple4(T1 _first, T2 _second, T3 _third, T4 _fourth)
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

		public static bool operator ==(Tuple4<T1, T2, T3, T4> a, Tuple4<T1, T2, T3, T4> b)
		{
			return default(bool);
		}

		public static bool operator !=(Tuple4<T1, T2, T3, T4> a, Tuple4<T1, T2, T3, T4> b)
		{
			return default(bool);
		}
	}
}
