namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecT131Field
	{
		private const ulong M03 = 7uL;

		private const ulong M44 = 17592186044415uL;

		private static readonly ulong[] ROOT_Z;

		public static void Add(ulong[] x, ulong[] y, ulong[] z)
		{
		}

		public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
		{
		}

		public static void AddOne(ulong[] x, ulong[] z)
		{
		}

		private static void AddTo(ulong[] x, ulong[] z)
		{
		}

		public static ulong[] FromBigInteger(BigInteger x)
		{
			return null;
		}

		public static void HalfTrace(ulong[] x, ulong[] z)
		{
		}

		public static void Invert(ulong[] x, ulong[] z)
		{
		}

		public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
		{
		}

		public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
		{
		}

		public static void Reduce(ulong[] xx, ulong[] z)
		{
		}

		public static void Reduce61(ulong[] z, int zOff)
		{
		}

		public static void Sqrt(ulong[] x, ulong[] z)
		{
		}

		public static void Square(ulong[] x, ulong[] z)
		{
		}

		public static void SquareAddToExt(ulong[] x, ulong[] zz)
		{
		}

		public static void SquareN(ulong[] x, int n, ulong[] z)
		{
		}

		public static uint Trace(ulong[] x)
		{
			return default(uint);
		}

		protected static void ImplCompactExt(ulong[] zz)
		{
		}

		protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
		{
		}

		protected static void ImplMulw(ulong x, ulong y, ulong[] z, int zOff)
		{
		}

		protected static void ImplSquare(ulong[] x, ulong[] zz)
		{
		}
	}
}
