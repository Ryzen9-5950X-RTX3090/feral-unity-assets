using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
	public class CompressedData : Asn1Encodable
	{
		private DerInteger version;

		private AlgorithmIdentifier compressionAlgorithm;

		private ContentInfo encapContentInfo;

		public DerInteger Version
		{
			get
			{
				return null;
			}
		}

		public AlgorithmIdentifier CompressionAlgorithmIdentifier
		{
			get
			{
				return null;
			}
		}

		public ContentInfo EncapContentInfo
		{
			get
			{
				return null;
			}
		}

		public CompressedData(AlgorithmIdentifier compressionAlgorithm, ContentInfo encapContentInfo)
		{
		}

		public CompressedData(Asn1Sequence seq)
		{
		}

		public static CompressedData GetInstance(Asn1TaggedObject ato, bool explicitly)
		{
			return null;
		}

		public static CompressedData GetInstance(object obj)
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
