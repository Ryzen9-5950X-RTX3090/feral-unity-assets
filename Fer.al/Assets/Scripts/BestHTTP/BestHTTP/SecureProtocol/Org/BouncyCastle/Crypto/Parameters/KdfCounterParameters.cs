namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class KdfCounterParameters : IDerivationParameters
	{
		private byte[] ki;

		private byte[] fixedInputDataCounterPrefix;

		private byte[] fixedInputDataCounterSuffix;

		private int r;

		public byte[] Ki
		{
			get
			{
				return null;
			}
		}

		public byte[] FixedInputData
		{
			get
			{
				return null;
			}
		}

		public byte[] FixedInputDataCounterPrefix
		{
			get
			{
				return null;
			}
		}

		public byte[] FixedInputDataCounterSuffix
		{
			get
			{
				return null;
			}
		}

		public int R
		{
			get
			{
				return default(int);
			}
		}

		public KdfCounterParameters(byte[] ki, byte[] fixedInputDataCounterSuffix, int r)
		{
		}

		public KdfCounterParameters(byte[] ki, byte[] fixedInputDataCounterPrefix, byte[] fixedInputDataCounterSuffix, int r)
		{
		}
	}
}
