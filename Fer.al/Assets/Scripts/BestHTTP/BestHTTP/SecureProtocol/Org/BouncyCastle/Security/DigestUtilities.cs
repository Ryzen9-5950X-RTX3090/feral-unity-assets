using System.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Security
{
	public sealed class DigestUtilities
	{
		private enum DigestAlgorithm
		{
			BLAKE2B_160,
			BLAKE2B_256,
			BLAKE2B_384,
			BLAKE2B_512,
			BLAKE2S_128,
			BLAKE2S_160,
			BLAKE2S_224,
			BLAKE2S_256,
			DSTU7564_256,
			DSTU7564_384,
			DSTU7564_512,
			GOST3411,
			GOST3411_2012_256,
			GOST3411_2012_512,
			KECCAK_224,
			KECCAK_256,
			KECCAK_288,
			KECCAK_384,
			KECCAK_512,
			MD2,
			MD4,
			MD5,
			NONE,
			RIPEMD128,
			RIPEMD160,
			RIPEMD256,
			RIPEMD320,
			SHA_1,
			SHA_224,
			SHA_256,
			SHA_384,
			SHA_512,
			SHA_512_224,
			SHA_512_256,
			SHA3_224,
			SHA3_256,
			SHA3_384,
			SHA3_512,
			SHAKE128,
			SHAKE256,
			SM3,
			TIGER,
			WHIRLPOOL
		}

		private static readonly IDictionary algorithms;

		private static readonly IDictionary oids;

		public static ICollection Algorithms
		{
			get
			{
				return null;
			}
		}

		private DigestUtilities()
		{
		}

		static DigestUtilities()
		{
		}

		public static DerObjectIdentifier GetObjectIdentifier(string mechanism)
		{
			return null;
		}

		public static IDigest GetDigest(DerObjectIdentifier id)
		{
			return null;
		}

		public static IDigest GetDigest(string algorithm)
		{
			return null;
		}

		public static string GetAlgorithmName(DerObjectIdentifier oid)
		{
			return null;
		}

		public static byte[] CalculateDigest(DerObjectIdentifier id, byte[] input)
		{
			return null;
		}

		public static byte[] CalculateDigest(string algorithm, byte[] input)
		{
			return null;
		}

		public static byte[] DoFinal(IDigest digest)
		{
			return null;
		}

		public static byte[] DoFinal(IDigest digest, byte[] input)
		{
			return null;
		}
	}
}
