using System;
using UnityEngine;

namespace Unitilities.Tuples
{
	[Serializable]
	public class Tuple3I : Tuple3<int, int, int>
	{
		public static Tuple3I zero
		{
			get
			{
				return null;
			}
		}

		public static Tuple3I one
		{
			get
			{
				return null;
			}
		}

		public Tuple3I(int a, int b, int c)
		{
		}

		public static Tuple3I operator +(Tuple3I a, Tuple3I b)
		{
			return null;
		}

		public static Tuple3I operator -(Tuple3I a, Tuple3I b)
		{
			return null;
		}

		public static Tuple3I operator *(Tuple3I a, Tuple3I b)
		{
			return null;
		}

		public static Tuple3I operator /(Tuple3I a, Tuple3I b)
		{
			return null;
		}

		public static implicit operator Vector3(Tuple3I t)
		{
			return default(Vector3);
		}

		public static implicit operator Tuple3I(Vector3 v)
		{
			return null;
		}
	}
}
