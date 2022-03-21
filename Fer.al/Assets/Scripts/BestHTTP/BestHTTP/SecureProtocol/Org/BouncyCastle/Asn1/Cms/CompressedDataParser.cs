using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
	public class CompressedDataParser
	{
		private DerInteger _version;

		private AlgorithmIdentifier _compressionAlgorithm;

		private ContentInfoParser _encapContentInfo;

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

		public CompressedDataParser(Asn1SequenceParser seq)
		{
		}

		public ContentInfoParser GetEncapContentInfo()
		{
			return null;
		}
	}
}
