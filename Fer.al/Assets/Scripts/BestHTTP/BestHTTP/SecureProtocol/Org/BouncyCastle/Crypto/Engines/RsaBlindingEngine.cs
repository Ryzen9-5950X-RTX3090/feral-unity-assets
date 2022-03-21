using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class RsaBlindingEngine : IAsymmetricBlockCipher
	{
		private readonly IRsa core;

		private RsaKeyParameters key;

		private BigInteger blindingFactor;

		private bool forEncryption;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public RsaBlindingEngine()
		{
		}

		public RsaBlindingEngine(IRsa rsa)
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

		private BigInteger BlindMessage(BigInteger msg)
		{
			return null;
		}

		private BigInteger UnblindMessage(BigInteger blindedMsg)
		{
			return null;
		}
	}
}
