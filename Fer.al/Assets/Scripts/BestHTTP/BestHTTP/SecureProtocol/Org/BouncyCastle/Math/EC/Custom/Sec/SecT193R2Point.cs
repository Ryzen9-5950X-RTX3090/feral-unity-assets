namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
	internal class SecT193R2Point : AbstractF2mPoint
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

		public SecT193R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		public SecT193R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		internal SecT193R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
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
