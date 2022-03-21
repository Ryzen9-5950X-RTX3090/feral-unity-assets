namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
	public class SimpleBlockResult : IBlockResult
	{
		private readonly byte[] result;

		public int Length
		{
			get
			{
				return default(int);
			}
		}

		public SimpleBlockResult(byte[] result)
		{
		}

		public byte[] Collect()
		{
			return null;
		}

		public int Collect(byte[] destination, int offset)
		{
			return default(int);
		}
	}
}
