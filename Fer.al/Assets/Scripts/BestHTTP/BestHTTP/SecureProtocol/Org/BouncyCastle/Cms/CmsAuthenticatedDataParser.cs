using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
	public class CmsAuthenticatedDataParser : CmsContentInfoParser
	{
		internal RecipientInformationStore _recipientInfoStore;

		internal AuthenticatedDataParser authData;

		private AlgorithmIdentifier macAlg;

		private byte[] mac;

		private BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable authAttrs;

		private BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable unauthAttrs;

		private bool authAttrNotRead;

		private bool unauthAttrNotRead;

		public AlgorithmIdentifier MacAlgorithmID
		{
			get
			{
				return null;
			}
		}

		public string MacAlgOid
		{
			get
			{
				return null;
			}
		}

		public Asn1Object MacAlgParams
		{
			get
			{
				return null;
			}
		}

		public CmsAuthenticatedDataParser(byte[] envelopedData)
		{
		}

		public CmsAuthenticatedDataParser(Stream envelopedData)
		{
		}

		public RecipientInformationStore GetRecipientInfos()
		{
			return null;
		}

		public byte[] GetMac()
		{
			return null;
		}

		public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable GetAuthAttrs()
		{
			return null;
		}

		public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable GetUnauthAttrs()
		{
			return null;
		}
	}
}
