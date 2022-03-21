using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Signers
{
	public class Ed448Signer : ISigner
	{
		private class Buffer : MemoryStream
		{
			internal byte[] GenerateSignature(Ed448PrivateKeyParameters privateKey, byte[] ctx)
			{
				return null;
			}

			internal bool VerifySignature(Ed448PublicKeyParameters publicKey, byte[] ctx, byte[] signature)
			{
				return default(bool);
			}

			internal void Reset()
			{
			}
		}

		private readonly Buffer buffer;

		private readonly byte[] context;

		private bool forSigning;

		private Ed448PrivateKeyParameters privateKey;

		private Ed448PublicKeyParameters publicKey;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public Ed448Signer(byte[] context)
		{
		}

		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		public virtual void Update(byte b)
		{
		}

		public virtual void BlockUpdate(byte[] buf, int off, int len)
		{
		}

		public virtual byte[] GenerateSignature()
		{
			return null;
		}

		public virtual bool VerifySignature(byte[] signature)
		{
			return default(bool);
		}

		public virtual void Reset()
		{
		}
	}
}
