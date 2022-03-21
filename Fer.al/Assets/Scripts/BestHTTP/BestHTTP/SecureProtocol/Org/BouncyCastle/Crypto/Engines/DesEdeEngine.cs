namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class DesEdeEngine : DesEngine
	{
		private int[] workingKey1;

		private int[] workingKey2;

		private int[] workingKey3;

		private bool forEncryption;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public override void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public override int GetBlockSize()
		{
			return default(int);
		}

		public override int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		public override void Reset()
		{
		}
	}
}
