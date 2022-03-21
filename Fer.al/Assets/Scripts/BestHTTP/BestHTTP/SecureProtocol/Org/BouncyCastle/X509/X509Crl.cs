using System;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Date;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
	public class X509Crl : X509ExtensionBase
	{
		private readonly CertificateList c;

		private readonly string sigAlgName;

		private readonly byte[] sigAlgParams;

		private readonly bool isIndirect;

		private bool hashValueSet;

		private int hashValue;

		public virtual int Version
		{
			get
			{
				return default(int);
			}
		}

		public virtual X509Name IssuerDN
		{
			get
			{
				return null;
			}
		}

		public virtual DateTime ThisUpdate
		{
			get
			{
				return default(DateTime);
			}
		}

		public virtual DateTimeObject NextUpdate
		{
			get
			{
				return null;
			}
		}

		public virtual string SigAlgName
		{
			get
			{
				return null;
			}
		}

		public virtual string SigAlgOid
		{
			get
			{
				return null;
			}
		}

		protected virtual bool IsIndirectCrl
		{
			get
			{
				return default(bool);
			}
		}

		public X509Crl(CertificateList c)
		{
		}

		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}

		public virtual byte[] GetEncoded()
		{
			return null;
		}

		public virtual void Verify(AsymmetricKeyParameter publicKey)
		{
		}

		public virtual void Verify(IVerifierFactoryProvider verifierProvider)
		{
		}

		protected virtual void CheckSignature(IVerifierFactory verifier)
		{
		}

		private ISet LoadCrlEntries()
		{
			return null;
		}

		public virtual X509CrlEntry GetRevokedCertificate(BigInteger serialNumber)
		{
			return null;
		}

		public virtual ISet GetRevokedCertificates()
		{
			return null;
		}

		public virtual byte[] GetTbsCertList()
		{
			return null;
		}

		public virtual byte[] GetSignature()
		{
			return null;
		}

		public virtual byte[] GetSigAlgParams()
		{
			return null;
		}

		public override bool Equals(object other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public virtual bool IsRevoked(X509Certificate cert)
		{
			return default(bool);
		}
	}
}
