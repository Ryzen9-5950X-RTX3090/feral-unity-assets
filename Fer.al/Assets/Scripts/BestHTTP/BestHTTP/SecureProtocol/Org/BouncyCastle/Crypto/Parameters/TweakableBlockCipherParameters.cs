namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class TweakableBlockCipherParameters : ICipherParameters
	{
		private readonly byte[] tweak;

		private readonly KeyParameter key;

		public KeyParameter Key
		{
			get
			{
				return null;
			}
		}

		public byte[] Tweak
		{
			get
			{
				return null;
			}
		}

		public TweakableBlockCipherParameters(KeyParameter key, byte[] tweak)
		{
		}
	}
}
