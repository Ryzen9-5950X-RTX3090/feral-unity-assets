using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	internal class TlsServerContextImpl : AbstractTlsContext, TlsServerContext, TlsContext
	{
		public override bool IsServer
		{
			get
			{
				return default(bool);
			}
		}

		internal TlsServerContextImpl(SecureRandom secureRandom, SecurityParameters securityParameters)
		{
		}
	}
}
