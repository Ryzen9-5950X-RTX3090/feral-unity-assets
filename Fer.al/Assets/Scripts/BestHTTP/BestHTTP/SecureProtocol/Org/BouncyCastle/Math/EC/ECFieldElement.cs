namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
	public abstract class ECFieldElement
	{
		public abstract string FieldName { get; }

		public abstract int FieldSize { get; }

		public virtual int BitLength
		{
			get
			{
				return default(int);
			}
		}

		public virtual bool IsOne
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsZero
		{
			get
			{
				return default(bool);
			}
		}

		public abstract BigInteger ToBigInteger();

		public abstract ECFieldElement Add(ECFieldElement b);

		public abstract ECFieldElement AddOne();

		public abstract ECFieldElement Subtract(ECFieldElement b);

		public abstract ECFieldElement Multiply(ECFieldElement b);

		public abstract ECFieldElement Divide(ECFieldElement b);

		public abstract ECFieldElement Negate();

		public abstract ECFieldElement Square();

		public abstract ECFieldElement Invert();

		public abstract ECFieldElement Sqrt();

		public virtual ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		public virtual ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		public virtual ECFieldElement SquareMinusProduct(ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		public virtual ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		public virtual ECFieldElement SquarePow(int pow)
		{
			return null;
		}

		public virtual bool TestBitZero()
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public virtual bool Equals(ECFieldElement other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public virtual byte[] GetEncoded()
		{
			return null;
		}
	}
}
