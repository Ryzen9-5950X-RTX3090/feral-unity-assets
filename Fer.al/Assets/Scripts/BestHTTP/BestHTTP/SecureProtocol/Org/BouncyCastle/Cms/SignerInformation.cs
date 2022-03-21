using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
	public class SignerInformation
	{
		private static readonly CmsSignedHelper Helper;

		private SignerID sid;

		private SignerInfo info;

		private AlgorithmIdentifier digestAlgorithm;

		private AlgorithmIdentifier encryptionAlgorithm;

		private readonly Asn1Set signedAttributeSet;

		private readonly Asn1Set unsignedAttributeSet;

		private CmsProcessable content;

		private byte[] signature;

		private DerObjectIdentifier contentType;

		private IDigestCalculator digestCalculator;

		private byte[] resultDigest;

		private BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttributeTable;

		private BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttributeTable;

		private readonly bool isCounterSignature;

		public bool IsCounterSignature
		{
			get
			{
				return default(bool);
			}
		}

		public DerObjectIdentifier ContentType
		{
			get
			{
				return null;
			}
		}

		public SignerID SignerID
		{
			get
			{
				return null;
			}
		}

		public int Version
		{
			get
			{
				return default(int);
			}
		}

		public AlgorithmIdentifier DigestAlgorithmID
		{
			get
			{
				return null;
			}
		}

		public string DigestAlgOid
		{
			get
			{
				return null;
			}
		}

		public Asn1Object DigestAlgParams
		{
			get
			{
				return null;
			}
		}

		public AlgorithmIdentifier EncryptionAlgorithmID
		{
			get
			{
				return null;
			}
		}

		public string EncryptionAlgOid
		{
			get
			{
				return null;
			}
		}

		public Asn1Object EncryptionAlgParams
		{
			get
			{
				return null;
			}
		}

		public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable SignedAttributes
		{
			get
			{
				return null;
			}
		}

		public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable UnsignedAttributes
		{
			get
			{
				return null;
			}
		}

		internal SignerInformation(SignerInfo info, DerObjectIdentifier contentType, CmsProcessable content, IDigestCalculator digestCalculator)
		{
		}

		protected SignerInformation(SignerInformation baseInfo)
		{
		}

		public byte[] GetContentDigest()
		{
			return null;
		}

		public byte[] GetSignature()
		{
			return null;
		}

		public SignerInformationStore GetCounterSignatures()
		{
			return null;
		}

		public byte[] GetEncodedSignedAttributes()
		{
			return null;
		}

		private bool DoVerify(AsymmetricKeyParameter key)
		{
			return default(bool);
		}

		private bool IsNull(Asn1Encodable o)
		{
			return default(bool);
		}

		private DigestInfo DerDecode(byte[] encoding)
		{
			return null;
		}

		private bool VerifyDigest(byte[] digest, AsymmetricKeyParameter key, byte[] signature)
		{
			return default(bool);
		}

		public bool Verify(AsymmetricKeyParameter pubKey)
		{
			return default(bool);
		}

		public bool Verify(X509Certificate cert)
		{
			return default(bool);
		}

		public SignerInfo ToSignerInfo()
		{
			return null;
		}

		private Asn1Object GetSingleValuedSignedAttribute(DerObjectIdentifier attrOID, string printableName)
		{
			return null;
		}

		private BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.Time GetSigningTime()
		{
			return null;
		}

		public static SignerInformation ReplaceUnsignedAttributes(SignerInformation signerInformation, BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttributes)
		{
			return null;
		}

		public static SignerInformation AddCounterSigners(SignerInformation signerInformation, SignerInformationStore counterSigners)
		{
			return null;
		}
	}
}
