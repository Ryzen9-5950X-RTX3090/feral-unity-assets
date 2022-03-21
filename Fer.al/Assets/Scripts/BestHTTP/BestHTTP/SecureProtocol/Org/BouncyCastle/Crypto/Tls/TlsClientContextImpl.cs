using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	internal class TlsClientContextImpl : AbstractTlsContext, TlsClientContext, TlsContext
	{
		public override bool IsServer
		{
			get
			{
				return default(bool);
			}
		}

		internal TlsClientContextImpl(SecureRandom secureRandom, SecurityParameters securityParameters)
		{
		}
	}
}
