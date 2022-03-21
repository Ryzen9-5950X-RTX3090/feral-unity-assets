using System.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class NaccacheSternEngine : IAsymmetricBlockCipher
	{
		private bool forEncryption;

		private NaccacheSternKeyParameters key;

		private IList[] lookup;

		public string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public virtual bool Debug
		{
			set
			{
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

		public virtual byte[] ProcessBlock(byte[] inBytes, int inOff, int length)
		{
			return null;
		}

		public virtual byte[] Encrypt(BigInteger plain)
		{
			return null;
		}

		public virtual byte[] AddCryptedBlocks(byte[] block1, byte[] block2)
		{
			return null;
		}

		public virtual byte[] ProcessData(byte[] data)
		{
			return null;
		}

		private static BigInteger chineseRemainder(IList congruences, IList primes)
		{
			return null;
		}
	}
}
