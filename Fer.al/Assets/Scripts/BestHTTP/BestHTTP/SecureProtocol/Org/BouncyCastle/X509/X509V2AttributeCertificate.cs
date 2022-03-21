using System;
using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.X509
{
	public class X509V2AttributeCertificate : X509ExtensionBase, IX509AttributeCertificate, IX509Extension
	{
		private readonly AttributeCertificate cert;

		private readonly DateTime notBefore;

		private readonly DateTime notAfter;

		public virtual int Version
		{
			get
			{
				return default(int);
			}
		}

		public virtual BigInteger SerialNumber
		{
			get
			{
				return null;
			}
		}

		public virtual AttributeCertificateHolder Holder
		{
			get
			{
				return null;
			}
		}

		public virtual AttributeCertificateIssuer Issuer
		{
			get
			{
				return null;
			}
		}

		public virtual DateTime NotBefore
		{
			get
			{
				return default(DateTime);
			}
		}

		public virtual DateTime NotAfter
		{
			get
			{
				return default(DateTime);
			}
		}

		public virtual bool IsValidNow
		{
			get
			{
				return default(bool);
			}
		}

		public virtual AlgorithmIdentifier SignatureAlgorithm
		{
			get
			{
				return null;
			}
		}

		private static AttributeCertificate GetObject(Stream input)
		{
			return null;
		}

		public X509V2AttributeCertificate(Stream encIn)
		{
		}

		public X509V2AttributeCertificate(byte[] encoded)
		{
		}

		internal X509V2AttributeCertificate(AttributeCertificate cert)
		{
		}

		public virtual bool[] GetIssuerUniqueID()
		{
			return null;
		}

		public virtual bool IsValid(DateTime date)
		{
			return default(bool);
		}

		public virtual void CheckValidity()
		{
		}

		public virtual void CheckValidity(DateTime date)
		{
		}

		public virtual byte[] GetSignature()
		{
			return null;
		}

		public virtual void Verify(AsymmetricKeyParameter key)
		{
		}

		public virtual void Verify(IVerifierFactoryProvider verifierProvider)
		{
		}

		protected virtual void CheckSignature(IVerifierFactory verifier)
		{
		}

		public virtual byte[] GetEncoded()
		{
			return null;
		}

		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}

		public virtual X509Attribute[] GetAttributes()
		{
			return null;
		}

		public virtual X509Attribute[] GetAttributes(string oid)
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
