using System;
using UnityEngine;

namespace Unitilities.Tuples
{
	[Serializable]
	public class TupleI : Tuple<int, int>
	{
		public static TupleI zero
		{
			get
			{
				return null;
			}
		}

		public static TupleI one
		{
			get
			{
				return null;
			}
		}

		public TupleI(int a, int b)
		{
		}

		public static TupleI operator +(TupleI a, TupleI b)
		{
			return null;
		}

		public static TupleI operator -(TupleI a, TupleI b)
		{
			return null;
		}

		public static TupleI operator *(TupleI a, TupleI b)
		{
			return null;
		}

		public static TupleI operator /(TupleI a, TupleI b)
		{
			return null;
		}

		public static implicit operator Vector2(TupleI t)
		{
			return default(Vector2);
		}

		public static implicit operator TupleI(Vector2 v)
		{
			return null;
		}
	}
}
