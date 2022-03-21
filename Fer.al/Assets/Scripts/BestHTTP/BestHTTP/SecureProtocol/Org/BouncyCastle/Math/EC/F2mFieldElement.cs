namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
	public class F2mFieldElement : AbstractF2mFieldElement
	{
		public const int Gnb = 1;

		public const int Tpb = 2;

		public const int Ppb = 3;

		private int representation;

		private int m;

		private int[] ks;

		internal LongArray x;

		public override int BitLength
		{
			get
			{
				return default(int);
			}
		}

		public override bool IsOne
		{
			get
			{
				return default(bool);
			}
		}

		public override bool IsZero
		{
			get
			{
				return default(bool);
			}
		}

		public override string FieldName
		{
			get
			{
				return null;
			}
		}

		public override int FieldSize
		{
			get
			{
				return default(int);
			}
		}

		public int Representation
		{
			get
			{
				return default(int);
			}
		}

		public int M
		{
			get
			{
				return default(int);
			}
		}

		public int K1
		{
			get
			{
				return default(int);
			}
		}

		public int K2
		{
			get
			{
				return default(int);
			}
		}

		public int K3
		{
			get
			{
				return default(int);
			}
		}

		public F2mFieldElement(int m, int k1, int k2, int k3, BigInteger x)
		{
		}

		public F2mFieldElement(int m, int k, BigInteger x)
		{
		}

		internal F2mFieldElement(int m, int[] ks, LongArray x)
		{
		}

		public override bool TestBitZero()
		{
			return default(bool);
		}

		public override BigInteger ToBigInteger()
		{
			return null;
		}

		public static void CheckFieldElements(ECFieldElement a, ECFieldElement b)
		{
		}

		public override ECFieldElement Add(ECFieldElement b)
		{
			return null;
		}

		public override ECFieldElement AddOne()
		{
			return null;
		}

		public override ECFieldElement Subtract(ECFieldElement b)
		{
			return null;
		}

		public override ECFieldElement Multiply(ECFieldElement b)
		{
			return null;
		}

		public override ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		public override ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		public override ECFieldElement Divide(ECFieldElement b)
		{
			return null;
		}

		public override ECFieldElement Negate()
		{
			return null;
		}

		public override ECFieldElement Square()
		{
			return null;
		}

		public override ECFieldElement SquareMinusProduct(ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		public override ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		public override ECFieldElement SquarePow(int pow)
		{
			return null;
		}

		public override ECFieldElement Invert()
		{
			return null;
		}

		public override ECFieldElement Sqrt()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public virtual bool Equals(F2mFieldElement other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
