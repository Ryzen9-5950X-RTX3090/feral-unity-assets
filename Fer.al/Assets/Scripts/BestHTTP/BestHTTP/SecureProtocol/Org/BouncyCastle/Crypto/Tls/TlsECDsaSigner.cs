namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class TlsECDsaSigner : TlsDsaSigner
	{
		protected override byte SignatureAlgorithm
		{
			get
			{
				return default(byte);
			}
		}

		public override bool IsValidPublicKey(AsymmetricKeyParameter publicKey)
		{
			return default(bool);
		}

		protected override IDsa CreateDsaImpl(byte hashAlgorithm)
		{
			return null;
		}
	}
}
