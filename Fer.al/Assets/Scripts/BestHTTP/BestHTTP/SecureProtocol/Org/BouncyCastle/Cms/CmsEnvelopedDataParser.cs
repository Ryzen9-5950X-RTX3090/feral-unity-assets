using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
	public class CmsEnvelopedDataParser : CmsContentInfoParser
	{
		internal RecipientInformationStore recipientInfoStore;

		internal EnvelopedDataParser envelopedData;

		private AlgorithmIdentifier _encAlg;

		private BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable _unprotectedAttributes;

		private bool _attrNotRead;

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

		public CmsEnvelopedDataParser(byte[] envelopedData)
		{
		}

		public CmsEnvelopedDataParser(Stream envelopedData)
		{
		}

		public RecipientInformationStore GetRecipientInfos()
		{
			return null;
		}

		public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable GetUnprotectedAttributes()
		{
			return null;
		}
	}
}
