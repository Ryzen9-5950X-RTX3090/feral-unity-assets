namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
	public abstract class ECPointBase : ECPoint
	{
		protected internal ECPointBase(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		protected internal ECPointBase(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		public override byte[] GetEncoded(bool compressed)
		{
			return null;
		}

		public override ECPoint Multiply(BigInteger k)
		{
			return null;
		}
	}
}
