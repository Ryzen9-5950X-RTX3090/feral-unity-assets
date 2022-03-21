using System;

namespace Unitilities.Tuples
{
	public static class TupleExtensions
	{
		public static T1 Max<T1>(this Tuple<T1, T1> t) where T1 : IComparable<T1>
		{
			return (T1)null;
		}

		public static T1 Min<T1>(this Tuple<T1, T1> t) where T1 : IComparable<T1>
		{
			return (T1)null;
		}

		public static T1 Max<T1>(this Tuple3<T1, T1, T1> t) where T1 : IComparable<T1>
		{
			return (T1)null;
		}

		public static T1 Min<T1>(this Tuple3<T1, T1, T1> t) where T1 : IComparable<T1>
		{
			return (T1)null;
		}

		public static T1 Max<T1>(this Tuple4<T1, T1, T1, T1> t) where T1 : IComparable<T1>
		{
			return (T1)null;
		}

		public static T1 Min<T1>(this Tuple4<T1, T1, T1, T1> t) where T1 : IComparable<T1>
		{
			return (T1)null;
		}
	}
}
