using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings
{
	public class ISO10126d2Padding : IBlockCipherPadding
	{
		private SecureRandom random;

		public string PaddingName
		{
			get
			{
				return null;
			}
		}

		public void Init(SecureRandom random)
		{
		}

		public int AddPadding(byte[] input, int inOff)
		{
			return default(int);
		}

		public int PadCount(byte[] input)
		{
			return default(int);
		}
	}
}
