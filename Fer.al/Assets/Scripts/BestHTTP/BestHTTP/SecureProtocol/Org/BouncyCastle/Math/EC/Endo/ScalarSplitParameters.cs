namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo
{
	public class ScalarSplitParameters
	{
		protected readonly BigInteger m_v1A;

		protected readonly BigInteger m_v1B;

		protected readonly BigInteger m_v2A;

		protected readonly BigInteger m_v2B;

		protected readonly BigInteger m_g1;

		protected readonly BigInteger m_g2;

		protected readonly int m_bits;

		public virtual BigInteger V1A
		{
			get
			{
				return null;
			}
		}

		public virtual BigInteger V1B
		{
			get
			{
				return null;
			}
		}

		public virtual BigInteger V2A
		{
			get
			{
				return null;
			}
		}

		public virtual BigInteger V2B
		{
			get
			{
				return null;
			}
		}

		public virtual BigInteger G1
		{
			get
			{
				return null;
			}
		}

		public virtual BigInteger G2
		{
			get
			{
				return null;
			}
		}

		public virtual int Bits
		{
			get
			{
				return default(int);
			}
		}

		private static void CheckVector(BigInteger[] v, string name)
		{
		}

		public ScalarSplitParameters(BigInteger[] v1, BigInteger[] v2, BigInteger g1, BigInteger g2, int bits)
		{
		}
	}
}
