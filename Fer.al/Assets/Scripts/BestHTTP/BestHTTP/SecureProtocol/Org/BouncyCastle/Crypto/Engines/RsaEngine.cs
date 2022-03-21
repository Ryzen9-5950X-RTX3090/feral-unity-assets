namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class RsaEngine : IAsymmetricBlockCipher
	{
		private readonly IRsa core;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public RsaEngine()
		{
		}

		public RsaEngine(IRsa rsa)
		{
		}

		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public virtual int GetInputBlockSize()
		{
			return default(int);
		}

		public virtual int GetOutputBlockSize()
		{
			return default(int);
		}

		public virtual byte[] ProcessBlock(byte[] inBuf, int inOff, int inLen)
		{
			return null;
		}
	}
}
