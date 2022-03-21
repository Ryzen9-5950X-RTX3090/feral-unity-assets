using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class TlsSrpLoginParameters
	{
		protected readonly Srp6GroupParameters mGroup;

		protected readonly BigInteger mVerifier;

		protected readonly byte[] mSalt;

		public virtual Srp6GroupParameters Group
		{
			get
			{
				return null;
			}
		}

		public virtual byte[] Salt
		{
			get
			{
				return null;
			}
		}

		public virtual BigInteger Verifier
		{
			get
			{
				return null;
			}
		}

		public TlsSrpLoginParameters(Srp6GroupParameters group, BigInteger verifier, byte[] salt)
		{
		}
	}
}
