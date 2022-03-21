using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class TlsServerProtocol : TlsProtocol
	{
		protected TlsServer mTlsServer;

		internal TlsServerContextImpl mTlsServerContext;

		protected TlsKeyExchange mKeyExchange;

		protected TlsCredentials mServerCredentials;

		protected CertificateRequest mCertificateRequest;

		protected short mClientCertificateType;

		protected TlsHandshakeHash mPrepareFinishHash;

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

		public TlsServerProtocol(Stream stream, SecureRandom secureRandom)
		{
		}

		public TlsServerProtocol(Stream input, Stream output, SecureRandom secureRandom)
		{
		}

		public TlsServerProtocol(SecureRandom secureRandom)
		{
		}

		public virtual void Accept(TlsServer tlsServer)
		{
		}

		protected override void CleanupHandshake()
		{
		}

		protected override void HandleHandshakeMessage(byte type, MemoryStream buf)
		{
		}

		protected override void HandleAlertWarningMessage(byte alertDescription)
		{
		}

		protected virtual void NotifyClientCertificate(Certificate clientCertificate)
		{
		}

		protected virtual void ReceiveCertificateMessage(MemoryStream buf)
		{
		}

		protected virtual void ReceiveCertificateVerifyMessage(MemoryStream buf)
		{
		}

		protected virtual void ReceiveClientHelloMessage(MemoryStream buf)
		{
		}

		protected virtual void ReceiveClientKeyExchangeMessage(MemoryStream buf)
		{
		}

		protected virtual void SendCertificateRequestMessage(CertificateRequest certificateRequest)
		{
		}

		protected virtual void SendCertificateStatusMessage(CertificateStatus certificateStatus)
		{
		}

		protected virtual void SendNewSessionTicketMessage(NewSessionTicket newSessionTicket)
		{
		}

		protected virtual void SendServerHelloMessage()
		{
		}

		protected virtual void SendServerHelloDoneMessage()
		{
		}

		protected virtual void SendServerKeyExchangeMessage(byte[] serverKeyExchange)
		{
		}

		protected virtual bool ExpectCertificateVerifyMessage()
		{
			return default(bool);
		}
	}
}
