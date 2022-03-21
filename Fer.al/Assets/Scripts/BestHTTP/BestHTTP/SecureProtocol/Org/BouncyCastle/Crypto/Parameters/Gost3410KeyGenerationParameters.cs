using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class Gost3410KeyGenerationParameters : KeyGenerationParameters
	{
		private readonly Gost3410Parameters parameters;

		private readonly DerObjectIdentifier publicKeyParamSet;

		public Gost3410Parameters Parameters
		{
			get
			{
				return null;
			}
		}

		public DerObjectIdentifier PublicKeyParamSet
		{
			get
			{
				return null;
			}
		}

		public Gost3410KeyGenerationParameters(SecureRandom random, Gost3410Parameters parameters)
		{
		}

		public Gost3410KeyGenerationParameters(SecureRandom random, DerObjectIdentifier publicKeyParamSet)
		{
		}

		private static Gost3410Parameters LookupParameters(DerObjectIdentifier publicKeyParamSet)
		{
			return null;
		}
	}
}
