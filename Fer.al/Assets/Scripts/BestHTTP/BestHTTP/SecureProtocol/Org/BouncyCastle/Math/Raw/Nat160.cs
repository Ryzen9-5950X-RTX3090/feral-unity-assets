namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Raw
{
	internal abstract class Nat160
	{
		private const ulong M = 4294967295uL;

		public static uint Add(uint[] x, uint[] y, uint[] z)
		{
			return default(uint);
		}

		public static uint AddBothTo(uint[] x, uint[] y, uint[] z)
		{
			return default(uint);
		}

		public static uint AddTo(uint[] x, uint[] z)
		{
			return default(uint);
		}

		public static uint AddTo(uint[] x, int xOff, uint[] z, int zOff, uint cIn)
		{
			return default(uint);
		}

		public static uint AddToEachOther(uint[] u, int uOff, uint[] v, int vOff)
		{
			return default(uint);
		}

		public static void Copy(uint[] x, uint[] z)
		{
		}

		public static void Copy(uint[] x, int xOff, uint[] z, int zOff)
		{
		}

		public static uint[] Create()
		{
			return null;
		}

		public static uint[] CreateExt()
		{
			return null;
		}

		public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			return default(bool);
		}

		public static bool Eq(uint[] x, uint[] y)
		{
			return default(bool);
		}

		public static uint[] FromBigInteger(BigInteger x)
		{
			return null;
		}

		public static uint GetBit(uint[] x, int bit)
		{
			return default(uint);
		}

		public static bool Gte(uint[] x, uint[] y)
		{
			return default(bool);
		}

		public static bool Gte(uint[] x, int xOff, uint[] y, int yOff)
		{
			return default(bool);
		}

		public static bool IsOne(uint[] x)
		{
			return default(bool);
		}

		public static bool IsZero(uint[] x)
		{
			return default(bool);
		}

		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
		}

		public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
		}

		public static uint MulAddTo(uint[] x, uint[] y, uint[] zz)
		{
			return default(uint);
		}

		public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			return default(uint);
		}

		public static ulong Mul33Add(uint w, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			return default(ulong);
		}

		public static uint MulWordAddExt(uint x, uint[] yy, int yyOff, uint[] zz, int zzOff)
		{
			return default(uint);
		}

		public static uint Mul33DWordAdd(uint x, ulong y, uint[] z, int zOff)
		{
			return default(uint);
		}

		public static uint Mul33WordAdd(uint x, uint y, uint[] z, int zOff)
		{
			return default(uint);
		}

		public static uint MulWordDwordAdd(uint x, ulong y, uint[] z, int zOff)
		{
			return default(uint);
		}

		public static uint MulWordsAdd(uint x, uint y, uint[] z, int zOff)
		{
			return default(uint);
		}

		public static uint MulWord(uint x, uint[] y, uint[] z, int zOff)
		{
			return default(uint);
		}

		public static void Square(uint[] x, uint[] zz)
		{
		}

		public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
		{
		}

		public static int Sub(uint[] x, uint[] y, uint[] z)
		{
			return default(int);
		}

		public static int Sub(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			return default(int);
		}

		public static int SubBothFrom(uint[] x, uint[] y, uint[] z)
		{
			return default(int);
		}

		public static int SubFrom(uint[] x, uint[] z)
		{
			return default(int);
		}

		public static int SubFrom(uint[] x, int xOff, uint[] z, int zOff)
		{
			return default(int);
		}

		public static BigInteger ToBigInteger(uint[] x)
		{
			return null;
		}

		public static void Zero(uint[] z)
		{
		}
	}
}
