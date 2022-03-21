using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public sealed class X448PrivateKeyParameters : AsymmetricKeyParameter
	{
		public static readonly int KeySize;

		public static readonly int SecretSize;

		private readonly byte[] data;

		public X448PrivateKeyParameters(SecureRandom random)
		{
		}

		public X448PrivateKeyParameters(byte[] buf, int off)
		{
		}

		public X448PrivateKeyParameters(Stream input)
		{
		}

		public void Encode(byte[] buf, int off)
		{
		}

		public byte[] GetEncoded()
		{
			return null;
		}

		public X448PublicKeyParameters GeneratePublicKey()
		{
			return null;
		}

		public void GenerateSecret(X448PublicKeyParameters publicKey, byte[] buf, int off)
		{
		}
	}
}
