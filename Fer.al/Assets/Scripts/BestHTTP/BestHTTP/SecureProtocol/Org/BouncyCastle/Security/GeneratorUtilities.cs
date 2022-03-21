using System.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Security
{
	public sealed class GeneratorUtilities
	{
		private static readonly IDictionary kgAlgorithms;

		private static readonly IDictionary kpgAlgorithms;

		private static readonly IDictionary defaultKeySizes;

		private GeneratorUtilities()
		{
		}

		static GeneratorUtilities()
		{
		}

		private static void AddDefaultKeySizeEntries(int size, string[] algorithms)
		{
		}

		private static void AddKgAlgorithm(string canonicalName, object[] aliases)
		{
		}

		private static void AddKpgAlgorithm(string canonicalName, object[] aliases)
		{
		}

		private static void AddHMacKeyGenerator(string algorithm, object[] aliases)
		{
		}

		internal static string GetCanonicalKeyGeneratorAlgorithm(string algorithm)
		{
			return null;
		}

		internal static string GetCanonicalKeyPairGeneratorAlgorithm(string algorithm)
		{
			return null;
		}

		public static CipherKeyGenerator GetKeyGenerator(DerObjectIdentifier oid)
		{
			return null;
		}

		public static CipherKeyGenerator GetKeyGenerator(string algorithm)
		{
			return null;
		}

		public static IAsymmetricCipherKeyPairGenerator GetKeyPairGenerator(DerObjectIdentifier oid)
		{
			return null;
		}

		public static IAsymmetricCipherKeyPairGenerator GetKeyPairGenerator(string algorithm)
		{
			return null;
		}

		internal static int GetDefaultKeySize(DerObjectIdentifier oid)
		{
			return default(int);
		}

		internal static int GetDefaultKeySize(string algorithm)
		{
			return default(int);
		}

		private static int FindDefaultKeySize(string canonicalName)
		{
			return default(int);
		}
	}
}
