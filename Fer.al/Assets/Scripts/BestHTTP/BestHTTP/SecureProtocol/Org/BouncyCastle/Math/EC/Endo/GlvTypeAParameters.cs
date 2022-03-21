namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo
{
	public class GlvTypeAParameters
	{
		protected readonly BigInteger m_i;

		protected readonly BigInteger m_lambda;

		protected readonly ScalarSplitParameters m_splitParams;

		public virtual BigInteger I
		{
			get
			{
				return null;
			}
		}

		public virtual BigInteger Lambda
		{
			get
			{
				return null;
			}
		}

		public virtual ScalarSplitParameters SplitParams
		{
			get
			{
				return null;
			}
		}

		public GlvTypeAParameters(BigInteger i, BigInteger lambda, ScalarSplitParameters splitParams)
		{
		}
	}
}
