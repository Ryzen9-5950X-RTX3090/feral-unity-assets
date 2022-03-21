using System;
using System.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp
{
	public class BasicOcspResp : X509ExtensionBase
	{
		private readonly BasicOcspResponse resp;

		private readonly ResponseData data;

		public int Version
		{
			get
			{
				return default(int);
			}
		}

		public RespID ResponderId
		{
			get
			{
				return null;
			}
		}

		public DateTime ProducedAt
		{
			get
			{
				return default(DateTime);
			}
		}

		public SingleResp[] Responses
		{
			get
			{
				return null;
			}
		}

		public X509Extensions ResponseExtensions
		{
			get
			{
				return null;
			}
		}

		public string SignatureAlgName
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

		public BasicOcspResp(BasicOcspResponse resp)
		{
		}

		public byte[] GetTbsResponseData()
		{
			return null;
		}

		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}

		public RespData GetResponseData()
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

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
