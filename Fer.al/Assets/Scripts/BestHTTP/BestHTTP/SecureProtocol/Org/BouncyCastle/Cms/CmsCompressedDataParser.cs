using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
	public class CmsCompressedDataParser : CmsContentInfoParser
	{
		public CmsCompressedDataParser(byte[] compressedData)
		{
		}

		public CmsCompressedDataParser(Stream compressedData)
		{
		}

		public CmsTypedStream GetContent()
		{
			return null;
		}
	}
}
