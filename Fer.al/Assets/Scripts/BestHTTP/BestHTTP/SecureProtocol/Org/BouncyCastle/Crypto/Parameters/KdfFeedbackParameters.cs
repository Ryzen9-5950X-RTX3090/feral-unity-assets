namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class KdfFeedbackParameters : IDerivationParameters
	{
		private static readonly int UNUSED_R;

		private readonly byte[] ki;

		private readonly byte[] iv;

		private readonly bool useCounter;

		private readonly int r;

		private readonly byte[] fixedInputData;

		public byte[] Ki
		{
			get
			{
				return null;
			}
		}

		public byte[] Iv
		{
			get
			{
				return null;
			}
		}

		public bool UseCounter
		{
			get
			{
				return default(bool);
			}
		}

		public int R
		{
			get
			{
				return default(int);
			}
		}

		public byte[] FixedInputData
		{
			get
			{
				return null;
			}
		}

		private KdfFeedbackParameters(byte[] ki, byte[] iv, byte[] fixedInputData, int r, bool useCounter)
		{
		}

		public static KdfFeedbackParameters CreateWithCounter(byte[] ki, byte[] iv, byte[] fixedInputData, int r)
		{
			return null;
		}

		public static KdfFeedbackParameters CreateWithoutCounter(byte[] ki, byte[] iv, byte[] fixedInputData)
		{
			return null;
		}
	}
}
