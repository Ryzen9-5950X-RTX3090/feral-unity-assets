using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
{
	public class HexEncoder : IEncoder
	{
		protected readonly byte[] encodingTable;

		protected readonly byte[] decodingTable;

		protected void InitialiseDecodingTable()
		{
		}

		public int Encode(byte[] data, int off, int length, Stream outStream)
		{
			return default(int);
		}

		private static bool Ignore(char c)
		{
			return default(bool);
		}

		public int Decode(byte[] data, int off, int length, Stream outStream)
		{
			return default(int);
		}

		public int DecodeString(string data, Stream outStream)
		{
			return default(int);
		}

		internal byte[] DecodeStrict(string str, int off, int len)
		{
			return null;
		}
	}
}
