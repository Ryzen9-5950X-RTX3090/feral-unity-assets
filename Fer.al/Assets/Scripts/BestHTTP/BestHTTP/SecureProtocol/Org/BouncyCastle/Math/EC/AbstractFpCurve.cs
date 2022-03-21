namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
	public abstract class AbstractFpCurve : ECCurve
	{
		protected AbstractFpCurve(BigInteger q)
		{
		}

		public override bool IsValidFieldElement(BigInteger x)
		{
			return default(bool);
		}

		protected override ECPoint DecompressPoint(int yTilde, BigInteger X1)
		{
			return null;
		}
	}
}
