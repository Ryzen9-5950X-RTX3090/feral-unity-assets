using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class ElGamalEngine : IAsymmetricBlockCipher
	{
		private ElGamalKeyParameters key;

		private SecureRandom random;

		private bool forEncryption;

		private int bitSize;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
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

		public virtual byte[] ProcessBlock(byte[] input, int inOff, int length)
		{
			return null;
		}
	}
}
