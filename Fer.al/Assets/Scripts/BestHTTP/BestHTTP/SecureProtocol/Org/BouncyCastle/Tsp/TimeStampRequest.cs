using System.Collections;
using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Tsp;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Tsp
{
	public class TimeStampRequest : X509ExtensionBase
	{
		private TimeStampReq req;

		private X509Extensions extensions;

		public int Version
		{
			get
			{
				return default(int);
			}
		}

		public string MessageImprintAlgOid
		{
			get
			{
				return null;
			}
		}

		public string ReqPolicy
		{
			get
			{
				return null;
			}
		}

		public BigInteger Nonce
		{
			get
			{
				return null;
			}
		}

		public bool CertReq
		{
			get
			{
				return default(bool);
			}
		}

		internal X509Extensions Extensions
		{
			get
			{
				return null;
			}
		}

		public virtual bool HasExtensions
		{
			get
			{
				return default(bool);
			}
		}

		public TimeStampRequest(TimeStampReq req)
		{
		}

		public TimeStampRequest(byte[] req)
		{
		}

		public TimeStampRequest(Stream input)
		{
		}

		private TimeStampRequest(Asn1InputStream str)
		{
		}

		public byte[] GetMessageImprintDigest()
		{
			return null;
		}

		public void Validate(IList algorithms, IList policies, IList extensions)
		{
		}

		public byte[] GetEncoded()
		{
			return null;
		}

		public virtual X509Extension GetExtension(DerObjectIdentifier oid)
		{
			return null;
		}

		public virtual IList GetExtensionOids()
		{
			return null;
		}

		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}
	}
}
