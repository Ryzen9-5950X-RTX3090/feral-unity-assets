namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
	public class FpCurve : AbstractFpCurve
	{
		private const int FP_DEFAULT_COORDS = 4;

		protected readonly BigInteger m_q;

		protected readonly BigInteger m_r;

		protected readonly FpPoint m_infinity;

		public virtual BigInteger Q
		{
			get
			{
				return null;
			}
		}

		public override ECPoint Infinity
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

		public FpCurve(BigInteger q, BigInteger a, BigInteger b)
		{
		}

		public FpCurve(BigInteger q, BigInteger a, BigInteger b, BigInteger order, BigInteger cofactor)
		{
		}

		protected FpCurve(BigInteger q, BigInteger r, ECFieldElement a, ECFieldElement b)
		{
		}

		protected FpCurve(BigInteger q, BigInteger r, ECFieldElement a, ECFieldElement b, BigInteger order, BigInteger cofactor)
		{
		}

		protected override ECCurve CloneCurve()
		{
			return null;
		}

		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		public override ECPoint ImportPoint(ECPoint p)
		{
			return null;
		}
	}
}
