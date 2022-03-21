using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class SignatureAndHashAlgorithm
	{
		protected readonly byte mHash;

		protected readonly byte mSignature;

		public virtual byte Hash
		{
			get
			{
				return default(byte);
			}
		}

		public virtual byte Signature
		{
			get
			{
				return default(byte);
			}
		}

		public SignatureAndHashAlgorithm(byte hash, byte signature)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public virtual void Encode(Stream output)
		{
		}

		public static SignatureAndHashAlgorithm Parse(Stream input)
		{
			return null;
		}
	}
}
