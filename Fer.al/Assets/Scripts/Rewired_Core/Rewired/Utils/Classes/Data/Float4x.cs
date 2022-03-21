using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public struct Float4x : IEquatable<Float4x>
	{
		public const int Length = 4;

		public float a;

		public float b;

		public float c;

		public float d;

		private static Func<Float4x, Float4x, Float4x> _additionDelegate;

		private static Func<Float4x, Float4x, Float4x> _subtractionDelegate;

		private static Func<Float4x, Float4x, Float4x> _multiplicationDelegate;

		private static Func<Float4x, Float4x, Float4x> _divisionDelegate;

		public float this[int index]
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public static Float4x Zero
		{
			get
			{
				return default(Float4x);
			}
		}

		public Float4x(float a, float b, float c, float d)
		{
		}

		public Float4x Clone()
		{
			return default(Float4x);
		}

		public static Float4x Clone(Float4x obj)
		{
			return default(Float4x);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public bool Equals(Float4x other)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}

		public static Float4x Add(Float4x value1, Float4x value2)
		{
			return default(Float4x);
		}

		public static Float4x Subtract(Float4x value1, Float4x value2)
		{
			return default(Float4x);
		}

		public static Float4x Multiply(Float4x value1, Float4x value2)
		{
			return default(Float4x);
		}

		public static Float4x Divide(Float4x value1, Float4x value2)
		{
			return default(Float4x);
		}

		public static Func<Float4x, Float4x, Float4x> GetAdditionDelegate()
		{
			return null;
		}

		public static Func<Float4x, Float4x, Float4x> GetSubtractionDelegate()
		{
			return null;
		}

		public static Func<Float4x, Float4x, Float4x> GetMultiplicationDelegate()
		{
			return null;
		}

		public static Func<Float4x, Float4x, Float4x> GetDivisionDelegate()
		{
			return null;
		}

		public static implicit operator Float4x(Vector4 obj)
		{
			return default(Float4x);
		}

		public static implicit operator Vector4(Float4x obj)
		{
			return default(Vector4);
		}

		public static Float4x operator +(Float4x value1, Float4x value2)
		{
			return default(Float4x);
		}

		public static Float4x operator -(Float4x value1, Float4x value2)
		{
			return default(Float4x);
		}

		public static Float4x operator *(Float4x value1, Float4x value2)
		{
			return default(Float4x);
		}

		public static Float4x operator /(Float4x value1, Float4x value2)
		{
			return default(Float4x);
		}

		public static Float4x operator +(Float4x value1, float value2)
		{
			return default(Float4x);
		}

		public static Float4x operator -(Float4x value1, float value2)
		{
			return default(Float4x);
		}

		public static Float4x operator *(Float4x value1, float value2)
		{
			return default(Float4x);
		}

		public static Float4x operator /(Float4x value1, float value2)
		{
			return default(Float4x);
		}
	}
}
