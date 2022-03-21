namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
	public abstract class AbstractFpPoint : ECPointBase
	{
		protected internal override bool CompressionYTilde
		{
			get
			{
				return default(bool);
			}
		}

		protected AbstractFpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		protected AbstractFpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		protected override bool SatisfiesCurveEquation()
		{
			return default(bool);
		}

		public override ECPoint Subtract(ECPoint b)
		{
			return null;
		}
	}
}
