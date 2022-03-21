namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class HC256Engine : IStreamCipher
	{
		private uint[] p;

		private uint[] q;

		private uint cnt;

		private byte[] key;

		private byte[] iv;

		private bool initialised;

		private byte[] buf;

		private int idx;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		private uint Step()
		{
			return default(uint);
		}

		private void Init()
		{
		}

		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		private byte GetByte()
		{
			return default(byte);
		}

		public virtual void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
		}

		public virtual void Reset()
		{
		}

		public virtual byte ReturnByte(byte input)
		{
			return default(byte);
		}

		private static uint RotateRight(uint x, int bits)
		{
			return default(uint);
		}
	}
}
