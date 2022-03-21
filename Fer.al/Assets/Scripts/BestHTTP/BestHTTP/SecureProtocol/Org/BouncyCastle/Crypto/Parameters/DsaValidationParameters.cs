namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class DsaValidationParameters
	{
		private readonly byte[] seed;

		private readonly int counter;

		private readonly int usageIndex;

		public virtual int Counter
		{
			get
			{
				return default(int);
			}
		}

		public virtual int UsageIndex
		{
			get
			{
				return default(int);
			}
		}

		public DsaValidationParameters(byte[] seed, int counter)
		{
		}

		public DsaValidationParameters(byte[] seed, int counter, int usageIndex)
		{
		}

		public virtual byte[] GetSeed()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected virtual bool Equals(DsaValidationParameters other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
