using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
{
	public class PemObject : PemObjectGenerator
	{
		private string type;

		private IList headers;

		private byte[] content;

		public string Type
		{
			get
			{
				return null;
			}
		}

		public IList Headers
		{
			get
			{
				return null;
			}
		}

		public byte[] Content
		{
			get
			{
				return null;
			}
		}

		public PemObject(string type, byte[] content)
		{
		}

		public PemObject(string type, IList headers, byte[] content)
		{
		}

		public PemObject Generate()
		{
			return null;
		}
	}
}
