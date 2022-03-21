using System.Collections;
using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms;
using BestHTTP.SecureProtocol.Org.BouncyCastle.X509.Store;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
	public class CmsSignedData
	{
		private static readonly CmsSignedHelper Helper;

		private readonly CmsProcessable signedContent;

		private SignedData signedData;

		private ContentInfo contentInfo;

		private SignerInformationStore signerInfoStore;

		private IX509Store attrCertStore;

		private IX509Store certificateStore;

		private IX509Store crlStore;

		private IDictionary hashes;

		public int Version
		{
			get
			{
				return default(int);
			}
		}

		public string SignedContentTypeOid
		{
			get
			{
				return null;
			}
		}

		public DerObjectIdentifier SignedContentType
		{
			get
			{
				return null;
			}
		}

		public CmsProcessable SignedContent
		{
			get
			{
				return null;
			}
		}

		public ContentInfo ContentInfo
		{
			get
			{
				return null;
			}
		}

		private CmsSignedData(CmsSignedData c)
		{
		}

		public CmsSignedData(byte[] sigBlock)
		{
		}

		public CmsSignedData(CmsProcessable signedContent, byte[] sigBlock)
		{
		}

		public CmsSignedData(IDictionary hashes, byte[] sigBlock)
		{
		}

		public CmsSignedData(CmsProcessable signedContent, Stream sigData)
		{
		}

		public CmsSignedData(Stream sigData)
		{
		}

		public CmsSignedData(CmsProcessable signedContent, ContentInfo sigData)
		{
		}

		public CmsSignedData(IDictionary hashes, ContentInfo sigData)
		{
		}

		public CmsSignedData(ContentInfo sigData)
		{
		}

		public SignerInformationStore GetSignerInfos()
		{
			return null;
		}

		public IX509Store GetAttributeCertificates(string type)
		{
			return null;
		}

		public IX509Store GetCertificates(string type)
		{
			return null;
		}

		public IX509Store GetCrls(string type)
		{
			return null;
		}

		public byte[] GetEncoded()
		{
			return null;
		}

		public byte[] GetEncoded(string encoding)
		{
			return null;
		}

		public static CmsSignedData ReplaceSigners(CmsSignedData signedData, SignerInformationStore signerInformationStore)
		{
			return null;
		}

		public static CmsSignedData ReplaceCertificatesAndCrls(CmsSignedData signedData, IX509Store x509Certs, IX509Store x509Crls, IX509Store x509AttrCerts)
		{
			return null;
		}
	}
}
