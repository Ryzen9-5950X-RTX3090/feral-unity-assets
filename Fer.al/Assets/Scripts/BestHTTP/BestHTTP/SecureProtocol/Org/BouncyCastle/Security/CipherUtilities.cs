using System.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Security
{
	public sealed class CipherUtilities
	{
		private enum CipherAlgorithm
		{
			AES,
			ARC4,
			BLOWFISH,
			CAMELLIA,
			CAST5,
			CAST6,
			CHACHA,
			CHACHA20_POLY1305,
			CHACHA7539,
			DES,
			DESEDE,
			ELGAMAL,
			GOST28147,
			HC128,
			HC256,
			IDEA,
			NOEKEON,
			PBEWITHSHAAND128BITRC4,
			PBEWITHSHAAND40BITRC4,
			RC2,
			RC5,
			RC5_64,
			RC6,
			RIJNDAEL,
			RSA,
			SALSA20,
			SEED,
			SERPENT,
			SKIPJACK,
			SM4,
			TEA,
			THREEFISH_256,
			THREEFISH_512,
			THREEFISH_1024,
			TNEPRES,
			TWOFISH,
			VMPC,
			VMPC_KSA3,
			XTEA
		}

		private enum CipherMode
		{
			ECB,
			NONE,
			CBC,
			CCM,
			CFB,
			CTR,
			CTS,
			EAX,
			GCM,
			GOFB,
			OCB,
			OFB,
			OPENPGPCFB,
			SIC
		}

		private enum CipherPadding
		{
			NOPADDING,
			RAW,
			ISO10126PADDING,
			ISO10126D2PADDING,
			ISO10126_2PADDING,
			ISO7816_4PADDING,
			ISO9797_1PADDING,
			ISO9796_1,
			ISO9796_1PADDING,
			OAEP,
			OAEPPADDING,
			OAEPWITHMD5ANDMGF1PADDING,
			OAEPWITHSHA1ANDMGF1PADDING,
			OAEPWITHSHA_1ANDMGF1PADDING,
			OAEPWITHSHA224ANDMGF1PADDING,
			OAEPWITHSHA_224ANDMGF1PADDING,
			OAEPWITHSHA256ANDMGF1PADDING,
			OAEPWITHSHA_256ANDMGF1PADDING,
			OAEPWITHSHA384ANDMGF1PADDING,
			OAEPWITHSHA_384ANDMGF1PADDING,
			OAEPWITHSHA512ANDMGF1PADDING,
			OAEPWITHSHA_512ANDMGF1PADDING,
			PKCS1,
			PKCS1PADDING,
			PKCS5,
			PKCS5PADDING,
			PKCS7,
			PKCS7PADDING,
			TBCPADDING,
			WITHCTS,
			X923PADDING,
			ZEROBYTEPADDING
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

		static CipherUtilities()
		{
		}

		private CipherUtilities()
		{
		}

		public static DerObjectIdentifier GetObjectIdentifier(string mechanism)
		{
			return null;
		}

		public static IBufferedCipher GetCipher(DerObjectIdentifier oid)
		{
			return null;
		}

		public static IBufferedCipher GetCipher(string algorithm)
		{
			return null;
		}

		public static string GetAlgorithmName(DerObjectIdentifier oid)
		{
			return null;
		}

		private static int GetDigitIndex(string s)
		{
			return default(int);
		}

		private static IBlockCipher CreateBlockCipher(CipherAlgorithm cipherAlgorithm)
		{
			return null;
		}
	}
}
