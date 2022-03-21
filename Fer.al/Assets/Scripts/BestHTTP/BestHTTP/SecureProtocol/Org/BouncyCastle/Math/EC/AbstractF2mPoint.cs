namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
	public abstract class AbstractF2mPoint : ECPointBase
	{
		protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		protected override bool SatisfiesCurveEquation()
		{
			return default(bool);
		}

		protected override bool SatisfiesOrder()
		{
			return default(bool);
		}

		public override ECPoint ScaleX(ECFieldElement scale)
		{
			return null;
		}

		public override ECPoint ScaleXNegateY(ECFieldElement scale)
		{
			return null;
		}

		public override ECPoint ScaleY(ECFieldElement scale)
		{
			return null;
		}

		public override ECPoint ScaleYNegateX(ECFieldElement scale)
		{
			return null;
		}

		public override ECPoint Subtract(ECPoint b)
		{
			return null;
		}

		public virtual AbstractF2mPoint Tau()
		{
			return null;
		}

		public virtual AbstractF2mPoint TauPow(int pow)
		{
			return null;
		}
	}
}
