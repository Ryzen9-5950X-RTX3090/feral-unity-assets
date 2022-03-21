namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class DHValidationParameters
	{
		private readonly byte[] seed;

		private readonly int counter;

		public int Counter
		{
			get
			{
				return default(int);
			}
		}

		public DHValidationParameters(byte[] seed, int counter)
		{
		}

		public byte[] GetSeed()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected bool Equals(DHValidationParameters other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
