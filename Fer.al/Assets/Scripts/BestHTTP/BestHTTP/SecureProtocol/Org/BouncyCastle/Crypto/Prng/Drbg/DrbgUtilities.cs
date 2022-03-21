using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.Drbg
{
	internal class DrbgUtilities
	{
		private static readonly IDictionary maxSecurityStrengths;

		static DrbgUtilities()
		{
		}

		internal static int GetMaxSecurityStrength(IDigest d)
		{
			return default(int);
		}

		internal static int GetMaxSecurityStrength(IMac m)
		{
			return default(int);
		}

		internal static byte[] HashDF(IDigest digest, byte[] seedMaterial, int seedLength)
		{
			return null;
		}

		internal static bool IsTooLarge(byte[] bytes, int maxBytes)
		{
			return default(bool);
		}
	}
}
