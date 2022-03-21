using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng
{
	internal interface IDrbgProvider
	{
		ISP80090Drbg Get(IEntropySource entropySource);
	}
}
