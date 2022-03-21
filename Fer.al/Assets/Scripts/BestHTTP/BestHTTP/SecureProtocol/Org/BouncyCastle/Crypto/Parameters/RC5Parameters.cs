namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class RC5Parameters : KeyParameter
	{
		private readonly int rounds;

		public int Rounds
		{
			get
			{
				return default(int);
			}
		}

		public RC5Parameters(byte[] key, int rounds)
		{
		}
	}
}
