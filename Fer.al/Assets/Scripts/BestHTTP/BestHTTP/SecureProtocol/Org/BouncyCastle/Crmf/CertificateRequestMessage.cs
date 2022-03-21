using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crmf
{
	public class CertificateRequestMessage
	{
		public static readonly int popRaVerified;

		public static readonly int popSigningKey;

		public static readonly int popKeyEncipherment;

		public static readonly int popKeyAgreement;

		private readonly CertReqMsg certReqMsg;

		private readonly Controls controls;

		public bool HasControls
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasProofOfPossession
		{
			get
			{
				return default(bool);
			}
		}

		public int ProofOfPossession
		{
			get
			{
				return default(int);
			}
		}

		public bool HasSigningKeyProofOfPossessionWithPkMac
		{
			get
			{
				return default(bool);
			}
		}

		private static CertReqMsg ParseBytes(byte[] encoding)
		{
			return null;
		}

		public CertificateRequestMessage(byte[] encoded)
		{
		}

		public CertificateRequestMessage(CertReqMsg certReqMsg)
		{
		}

		public CertReqMsg ToAsn1Structure()
		{
			return null;
		}

		public CertTemplate GetCertTemplate()
		{
			return null;
		}

		public bool HasControl(DerObjectIdentifier objectIdentifier)
		{
			return default(bool);
		}

		public IControl GetControl(DerObjectIdentifier type)
		{
			return null;
		}

		public AttributeTypeAndValue FindControl(DerObjectIdentifier type)
		{
			return null;
		}

		public bool IsValidSigningKeyPop(IVerifierFactoryProvider verifierProvider)
		{
			return default(bool);
		}

		private bool verifySignature(IVerifierFactoryProvider verifierFactoryProvider, PopoSigningKey signKey)
		{
			return default(bool);
		}

		public byte[] GetEncoded()
		{
			return null;
		}
	}
}
