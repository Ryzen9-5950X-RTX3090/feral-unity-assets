using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.OpenSsl
{
	internal sealed class PemUtilities
	{
		private enum PemBaseAlg
		{
			AES_128,
			AES_192,
			AES_256,
			BF,
			DES,
			DES_EDE,
			DES_EDE3,
			RC2,
			RC2_40,
			RC2_64
		}

		private enum PemMode
		{
			CBC,
			CFB,
			ECB,
			OFB
		}

		static PemUtilities()
		{
		}

		private static void ParseDekAlgName(string dekAlgName, out PemBaseAlg baseAlg, out PemMode mode)
		{
		}

		internal static byte[] Crypt(bool encrypt, byte[] bytes, char[] password, string dekAlgName, byte[] iv)
		{
			return null;
		}

		private static ICipherParameters GetCipherParameters(char[] password, PemBaseAlg baseAlg, byte[] salt)
		{
			return null;
		}
	}
}
