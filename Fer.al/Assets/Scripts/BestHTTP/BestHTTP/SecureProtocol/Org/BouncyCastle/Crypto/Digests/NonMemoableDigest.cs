namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	public class NonMemoableDigest : IDigest
	{
		protected readonly IDigest mBaseDigest;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public NonMemoableDigest(IDigest baseDigest)
		{
		}

		public virtual int GetDigestSize()
		{
			return default(int);
		}

		public virtual void Update(byte input)
		{
		}

		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		public virtual int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}

		public virtual void Reset()
		{
		}

		public virtual int GetByteLength()
		{
			return default(int);
		}
	}
}
