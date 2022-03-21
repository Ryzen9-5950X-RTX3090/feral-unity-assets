namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class KdfDoublePipelineIterationParameters : IDerivationParameters
	{
		private static readonly int UNUSED_R;

		private readonly byte[] ki;

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

		private KdfDoublePipelineIterationParameters(byte[] ki, byte[] fixedInputData, int r, bool useCounter)
		{
		}

		public static KdfDoublePipelineIterationParameters CreateWithCounter(byte[] ki, byte[] fixedInputData, int r)
		{
			return null;
		}

		public static KdfDoublePipelineIterationParameters CreateWithoutCounter(byte[] ki, byte[] fixedInputData)
		{
			return null;
		}
	}
}
