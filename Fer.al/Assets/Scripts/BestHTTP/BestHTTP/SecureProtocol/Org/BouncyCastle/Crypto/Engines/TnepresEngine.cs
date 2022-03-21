namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public sealed class TnepresEngine : SerpentEngineBase
	{
		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		protected override int[] MakeWorkingKey(byte[] key)
		{
			return null;
		}

		protected override void EncryptBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
		}

		protected override void DecryptBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
		}
	}
}
