using System.Collections;
using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
	public class OcspReq : X509ExtensionBase
	{
		private OcspRequest req;

		public int Version
		{
			get
			{
				return default(int);
			}
		}

		public GeneralName RequestorName
		{
			get
			{
				return null;
			}
		}

		public X509Extensions RequestExtensions
		{
			get
			{
				return null;
			}
		}

		public string SignatureAlgOid
		{
			get
			{
				return null;
			}
		}

		public bool IsSigned
		{
			get
			{
				return default(bool);
			}
		}

		public OcspReq(OcspRequest req)
		{
		}

		public OcspReq(byte[] req)
		{
		}

		public OcspReq(Stream inStr)
		{
		}

		private OcspReq(Asn1InputStream aIn)
		{
		}

		public byte[] GetTbsRequest()
		{
			return null;
		}

		public Req[] GetRequestList()
		{
			return null;
		}

		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}

		public byte[] GetSignature()
		{
			return null;
		}

		private IList GetCertList()
		{
			return null;
		}

		public X509Certificate[] GetCerts()
		{
			return null;
		}

		public IX509Store GetCertificates(string type)
		{
			return null;
		}

		public bool Verify(AsymmetricKeyParameter publicKey)
		{
			return default(bool);
		}

		public byte[] GetEncoded()
		{
			return null;
		}
	}
}
