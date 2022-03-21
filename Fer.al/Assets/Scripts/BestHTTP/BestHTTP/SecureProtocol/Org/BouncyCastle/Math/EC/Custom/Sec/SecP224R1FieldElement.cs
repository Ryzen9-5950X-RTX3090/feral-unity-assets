namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecP224R1FieldElement : AbstractFpFieldElement
	{
		public static readonly BigInteger Q;

		protected internal readonly uint[] x;

		public override bool IsZero
		{
			get
			{
				return default(bool);
			}
		}

		public override bool IsOne
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

		public SecP224R1FieldElement(BigInteger x)
		{
		}

		public SecP224R1FieldElement()
		{
		}

		protected internal SecP224R1FieldElement(uint[] x)
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

		public override bool Equals(ECFieldElement other)
		{
			return default(bool);
		}

		public virtual bool Equals(SecP224R1FieldElement other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		private static bool IsSquare(uint[] x)
		{
			return default(bool);
		}

		private static void RM(uint[] nc, uint[] d0, uint[] e0, uint[] d1, uint[] e1, uint[] f1, uint[] t)
		{
		}

		private static void RP(uint[] nc, uint[] d1, uint[] e1, uint[] f1, uint[] t)
		{
		}

		private static void RS(uint[] d, uint[] e, uint[] f, uint[] t)
		{
		}

		private static bool TrySqrt(uint[] nc, uint[] r, uint[] t)
		{
			return default(bool);
		}
	}
}
