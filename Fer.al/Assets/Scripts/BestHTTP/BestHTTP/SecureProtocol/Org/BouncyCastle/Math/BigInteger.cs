using System;
using System.Collections;
using System.Text;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math
{
	[Serializable]
	public class BigInteger
	{
		internal static readonly int[][] primeLists;

		internal static readonly int[] primeProducts;

		private const long IMASK = 4294967295L;

		private const ulong UIMASK = 4294967295uL;

		private static readonly int[] ZeroMagnitude;

		private static readonly byte[] ZeroEncoding;

		private static readonly BigInteger[] SMALL_CONSTANTS;

		public static readonly BigInteger Zero;

		public static readonly BigInteger One;

		public static readonly BigInteger Two;

		public static readonly BigInteger Three;

		public static readonly BigInteger Four;

		public static readonly BigInteger Ten;

		private static readonly byte[] BitLengthTable;

		private const int chunk2 = 1;

		private const int chunk8 = 1;

		private const int chunk10 = 19;

		private const int chunk16 = 16;

		private static readonly BigInteger radix2;

		private static readonly BigInteger radix2E;

		private static readonly BigInteger radix8;

		private static readonly BigInteger radix8E;

		private static readonly BigInteger radix10;

		private static readonly BigInteger radix10E;

		private static readonly BigInteger radix16;

		private static readonly BigInteger radix16E;

		private static readonly SecureRandom RandomSource;

		private static readonly int[] ExpWindowThresholds;

		private const int BitsPerByte = 8;

		private const int BitsPerInt = 32;

		private const int BytesPerInt = 4;

		private int[] magnitude;

		private int sign;

		private int nBits;

		private int nBitLength;

		private int mQuote;

		public int BitCount
		{
			get
			{
				return default(int);
			}
		}

		public int BitLength
		{
			get
			{
				return default(int);
			}
		}

		public int IntValue
		{
			get
			{
				return default(int);
			}
		}

		public int IntValueExact
		{
			get
			{
				return default(int);
			}
		}

		public long LongValue
		{
			get
			{
				return default(long);
			}
		}

		public long LongValueExact
		{
			get
			{
				return default(long);
			}
		}

		public int SignValue
		{
			get
			{
				return default(int);
			}
		}

		static BigInteger()
		{
		}

		private static int GetByteLength(int nBits)
		{
			return default(int);
		}

		public static BigInteger Arbitrary(int sizeInBits)
		{
			return null;
		}

		private BigInteger(int signum, int[] mag, bool checkMag)
		{
		}

		public BigInteger(string value)
		{
		}

		public BigInteger(string str, int radix)
		{
		}

		public BigInteger(byte[] bytes)
		{
		}

		public BigInteger(byte[] bytes, int offset, int length)
		{
		}

		private static int[] MakeMagnitude(byte[] bytes, int offset, int length)
		{
			return null;
		}

		public BigInteger(int sign, byte[] bytes)
		{
		}

		public BigInteger(int sign, byte[] bytes, int offset, int length)
		{
		}

		public BigInteger(int sizeInBits, Random random)
		{
		}

		public BigInteger(int bitLength, int certainty, Random random)
		{
		}

		public BigInteger Abs()
		{
			return null;
		}

		private static int[] AddMagnitudes(int[] a, int[] b)
		{
			return null;
		}

		public BigInteger Add(BigInteger value)
		{
			return null;
		}

		private BigInteger AddToMagnitude(int[] magToAdd)
		{
			return null;
		}

		public BigInteger And(BigInteger value)
		{
			return null;
		}

		public BigInteger AndNot(BigInteger val)
		{
			return null;
		}

		public static int BitCnt(int i)
		{
			return default(int);
		}

		private static int CalcBitLength(int sign, int indx, int[] mag)
		{
			return default(int);
		}

		internal static int BitLen(int w)
		{
			return default(int);
		}

		private bool QuickPow2Check()
		{
			return default(bool);
		}

		public int CompareTo(object obj)
		{
			return default(int);
		}

		private static int CompareTo(int xIndx, int[] x, int yIndx, int[] y)
		{
			return default(int);
		}

		private static int CompareNoLeadingZeroes(int xIndx, int[] x, int yIndx, int[] y)
		{
			return default(int);
		}

		public int CompareTo(BigInteger value)
		{
			return default(int);
		}

		private int[] Divide(int[] x, int[] y)
		{
			return null;
		}

		public BigInteger Divide(BigInteger val)
		{
			return null;
		}

		public BigInteger[] DivideAndRemainder(BigInteger val)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		private bool IsEqualMagnitude(BigInteger x)
		{
			return default(bool);
		}

		public BigInteger Gcd(BigInteger value)
		{
			return null;
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		private BigInteger Inc()
		{
			return null;
		}

		public bool IsProbablePrime(int certainty)
		{
			return default(bool);
		}

		internal bool IsProbablePrime(int certainty, bool randomlySelected)
		{
			return default(bool);
		}

		private bool CheckProbablePrime(int certainty, Random random, bool randomlySelected)
		{
			return default(bool);
		}

		public bool RabinMillerTest(int certainty, Random random)
		{
			return default(bool);
		}

		internal bool RabinMillerTest(int certainty, Random random, bool randomlySelected)
		{
			return default(bool);
		}

		public BigInteger Max(BigInteger value)
		{
			return null;
		}

		public BigInteger Min(BigInteger value)
		{
			return null;
		}

		public BigInteger Mod(BigInteger m)
		{
			return null;
		}

		public BigInteger ModInverse(BigInteger m)
		{
			return null;
		}

		private BigInteger ModInversePow2(BigInteger m)
		{
			return null;
		}

		private static int ModInverse32(int d)
		{
			return default(int);
		}

		private static long ModInverse64(long d)
		{
			return default(long);
		}

		private static BigInteger ExtEuclid(BigInteger a, BigInteger b, out BigInteger u1Out)
		{
			return null;
		}

		private static void ZeroOut(int[] x)
		{
		}

		public BigInteger ModPow(BigInteger e, BigInteger m)
		{
			return null;
		}

		private static BigInteger ModPowBarrett(BigInteger b, BigInteger e, BigInteger m)
		{
			return null;
		}

		private static BigInteger ReduceBarrett(BigInteger x, BigInteger m, BigInteger mr, BigInteger yu)
		{
			return null;
		}

		private static BigInteger ModPowMonty(BigInteger b, BigInteger e, BigInteger m, bool convert)
		{
			return null;
		}

		private static int[] GetWindowList(int[] mag, int extraBits)
		{
			return null;
		}

		private static int CreateWindowEntry(int mult, int zeroes)
		{
			return default(int);
		}

		private static int[] Square(int[] w, int[] x)
		{
			return null;
		}

		private static int[] Multiply(int[] x, int[] y, int[] z)
		{
			return null;
		}

		private int GetMQuote()
		{
			return default(int);
		}

		private static void MontgomeryReduce(int[] x, int[] m, uint mDash)
		{
		}

		private static void MultiplyMonty(int[] a, int[] x, int[] y, int[] m, uint mDash, bool smallMontyModulus)
		{
		}

		private static void SquareMonty(int[] a, int[] x, int[] m, uint mDash, bool smallMontyModulus)
		{
		}

		private static uint MultiplyMontyNIsOne(uint x, uint y, uint m, uint mDash)
		{
			return default(uint);
		}

		public BigInteger Multiply(BigInteger val)
		{
			return null;
		}

		public BigInteger Square()
		{
			return null;
		}

		public BigInteger Negate()
		{
			return null;
		}

		public BigInteger NextProbablePrime()
		{
			return null;
		}

		public BigInteger Not()
		{
			return null;
		}

		public BigInteger Pow(int exp)
		{
			return null;
		}

		public static BigInteger ProbablePrime(int bitLength, Random random)
		{
			return null;
		}

		private int Remainder(int m)
		{
			return default(int);
		}

		private static int[] Remainder(int[] x, int[] y)
		{
			return null;
		}

		public BigInteger Remainder(BigInteger n)
		{
			return null;
		}

		private int[] LastNBits(int n)
		{
			return null;
		}

		private BigInteger DivideWords(int w)
		{
			return null;
		}

		private BigInteger RemainderWords(int w)
		{
			return null;
		}

		private static int[] ShiftLeft(int[] mag, int n)
		{
			return null;
		}

		private static int ShiftLeftOneInPlace(int[] x, int carry)
		{
			return default(int);
		}

		public BigInteger ShiftLeft(int n)
		{
			return null;
		}

		private static void ShiftRightInPlace(int start, int[] mag, int n)
		{
		}

		private static void ShiftRightOneInPlace(int start, int[] mag)
		{
		}

		public BigInteger ShiftRight(int n)
		{
			return null;
		}

		private static int[] Subtract(int xStart, int[] x, int yStart, int[] y)
		{
			return null;
		}

		public BigInteger Subtract(BigInteger n)
		{
			return null;
		}

		private static int[] doSubBigLil(int[] bigMag, int[] lilMag)
		{
			return null;
		}

		public byte[] ToByteArray()
		{
			return null;
		}

		public byte[] ToByteArrayUnsigned()
		{
			return null;
		}

		private byte[] ToByteArray(bool unsigned)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(int radix)
		{
			return null;
		}

		private static void ToString(StringBuilder sb, int radix, IList moduli, int scale, BigInteger pos)
		{
		}

		private static void AppendZeroExtendedString(StringBuilder sb, string s, int minLength)
		{
		}

		private static BigInteger CreateUValueOf(ulong value)
		{
			return null;
		}

		private static BigInteger CreateValueOf(long value)
		{
			return null;
		}

		public static BigInteger ValueOf(long value)
		{
			return null;
		}

		public int GetLowestSetBit()
		{
			return default(int);
		}

		private int GetLowestSetBitMaskFirst(int firstWordMask)
		{
			return default(int);
		}

		public bool TestBit(int n)
		{
			return default(bool);
		}

		public BigInteger Or(BigInteger value)
		{
			return null;
		}

		public BigInteger Xor(BigInteger value)
		{
			return null;
		}

		public BigInteger SetBit(int n)
		{
			return null;
		}

		public BigInteger ClearBit(int n)
		{
			return null;
		}

		public BigInteger FlipBit(int n)
		{
			return null;
		}

		private BigInteger FlipExistingBit(int n)
		{
			return null;
		}
	}
}
