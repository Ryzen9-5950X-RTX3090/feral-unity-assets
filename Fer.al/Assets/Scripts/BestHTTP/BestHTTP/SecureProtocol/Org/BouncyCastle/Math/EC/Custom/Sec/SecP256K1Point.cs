namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecP256K1Point : AbstractFpPoint
	{
		public SecP256K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		public SecP256K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		internal SecP256K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		protected override ECPoint Detach()
		{
			return null;
		}

		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		public override ECPoint Twice()
		{
			return null;
		}

		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		public override ECPoint ThreeTimes()
		{
			return null;
		}

		public override ECPoint Negate()
		{
			return null;
		}
	}
}
