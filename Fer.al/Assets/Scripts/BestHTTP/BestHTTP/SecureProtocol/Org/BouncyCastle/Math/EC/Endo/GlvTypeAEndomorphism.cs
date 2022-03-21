namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo
{
	public class GlvTypeAEndomorphism : GlvEndomorphism, ECEndomorphism
	{
		protected readonly GlvTypeAParameters m_parameters;

		protected readonly ECPointMap m_pointMap;

		public virtual ECPointMap PointMap
		{
			get
			{
				return null;
			}
		}

		public virtual bool HasEfficientPointMap
		{
			get
			{
				return default(bool);
			}
		}

		public GlvTypeAEndomorphism(ECCurve curve, GlvTypeAParameters parameters)
		{
		}

		public virtual BigInteger[] DecomposeScalar(BigInteger k)
		{
			return null;
		}
	}
}
