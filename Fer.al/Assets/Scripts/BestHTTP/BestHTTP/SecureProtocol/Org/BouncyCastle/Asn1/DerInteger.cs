using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1
{
	public class DerInteger : Asn1Object
	{
		public const string AllowUnsafeProperty = "BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.AllowUnsafeInteger";

		internal const int SignExtSigned = -1;

		internal const int SignExtUnsigned = 255;

		private readonly byte[] bytes;

		private readonly int start;

		public BigInteger PositiveValue
		{
			get
			{
				return null;
			}
		}

		public BigInteger Value
		{
			get
			{
				return null;
			}
		}

		public int IntPositiveValueExact
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

		public long LongValueExact
		{
			get
			{
				return default(long);
			}
		}

		internal static bool AllowUnsafe()
		{
			return default(bool);
		}

		public static DerInteger GetInstance(object obj)
		{
			return null;
		}

		public static DerInteger GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		public DerInteger(int value)
		{
		}

		public DerInteger(long value)
		{
		}

		public DerInteger(BigInteger value)
		{
		}

		public DerInteger(byte[] bytes)
		{
		}

		internal DerInteger(byte[] bytes, bool clone)
		{
		}

		public bool HasValue(BigInteger x)
		{
			return default(bool);
		}

		internal override void Encode(DerOutputStream derOut)
		{
		}

		protected override int Asn1GetHashCode()
		{
			return default(int);
		}

		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}

		internal static int IntValue(byte[] bytes, int start, int signExt)
		{
			return default(int);
		}

		internal static long LongValue(byte[] bytes, int start, int signExt)
		{
			return default(long);
		}

		internal static bool IsMalformed(byte[] bytes)
		{
			return default(bool);
		}

		internal static int SignBytesToSkip(byte[] bytes)
		{
			return default(int);
		}
	}
}
