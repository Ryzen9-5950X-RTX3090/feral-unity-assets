using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public sealed class X25519PublicKeyParameters : AsymmetricKeyParameter
	{
		public static readonly int KeySize;

		private readonly byte[] data;

		public X25519PublicKeyParameters(byte[] buf, int off)
		{
		}

		public X25519PublicKeyParameters(Stream input)
		{
		}

		public void Encode(byte[] buf, int off)
		{
		}

		public byte[] GetEncoded()
		{
			return null;
		}
	}
}
