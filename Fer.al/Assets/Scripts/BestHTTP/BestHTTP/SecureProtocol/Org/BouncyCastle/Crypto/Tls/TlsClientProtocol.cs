using System.Collections;
using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class TlsClientProtocol : TlsProtocol
	{
		protected TlsClient mTlsClient;

		internal TlsClientContextImpl mTlsClientContext;

		protected byte[] mSelectedSessionID;

		protected TlsKeyExchange mKeyExchange;

		protected TlsAuthentication mAuthentication;

		protected CertificateRequest mCertificateRequest;

		protected override TlsContext Context
		{
			get
			{
				return null;
			}
		}

		internal override AbstractTlsContext ContextAdmin
		{
			get
			{
				return null;
			}
		}

		protected override TlsPeer Peer
		{
			get
			{
				return null;
			}
		}

		public TlsClientProtocol(Stream stream, SecureRandom secureRandom)
		{
		}

		public TlsClientProtocol(Stream input, Stream output, SecureRandom secureRandom)
		{
		}

		public TlsClientProtocol(SecureRandom secureRandom)
		{
		}

		public virtual void Connect(TlsClient tlsClient)
		{
		}

		protected override void CleanupHandshake()
		{
		}

		protected override void HandleHandshakeMessage(byte type, MemoryStream buf)
		{
		}

		protected virtual void HandleSupplementalData(IList serverSupplementalData)
		{
		}

		protected virtual void ReceiveNewSessionTicketMessage(MemoryStream buf)
		{
		}

		protected virtual void ReceiveServerHelloMessage(MemoryStream buf)
		{
		}

		protected virtual void SendCertificateVerifyMessage(DigitallySigned certificateVerify)
		{
		}

		protected virtual void SendClientHelloMessage()
		{
		}

		protected virtual void SendClientKeyExchangeMessage()
		{
		}
	}
}
