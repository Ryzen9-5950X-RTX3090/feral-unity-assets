using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class RsaBlindedEngine : IAsymmetricBlockCipher
	{
		private readonly IRsa core;

		private RsaKeyParameters key;

		private SecureRandom random;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public RsaBlindedEngine()
		{
		}

		public RsaBlindedEngine(IRsa rsa)
		{
		}

		public virtual void Init(bool forEncryption, ICipherParameters param)
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
