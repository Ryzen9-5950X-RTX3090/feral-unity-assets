namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecT113R2Point : AbstractF2mPoint
	{
		public override ECFieldElement YCoord
		{
			get
			{
				return null;
			}
		}

		protected internal override bool CompressionYTilde
		{
			get
			{
				return default(bool);
			}
		}

		public SecT113R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		public SecT113R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		internal SecT113R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
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

		public override ECPoint Negate()
		{
			return null;
		}
	}
}
