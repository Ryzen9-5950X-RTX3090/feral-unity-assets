namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class HC128Engine : IStreamCipher
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

		private static uint F1(uint x)
		{
			return default(uint);
		}

		private static uint F2(uint x)
		{
			return default(uint);
		}

		private uint G1(uint x, uint y, uint z)
		{
			return default(uint);
		}

		private uint G2(uint x, uint y, uint z)
		{
			return default(uint);
		}

		private static uint RotateLeft(uint x, int bits)
		{
			return default(uint);
		}

		private static uint RotateRight(uint x, int bits)
		{
			return default(uint);
		}

		private uint H1(uint x)
		{
			return default(uint);
		}

		private uint H2(uint x)
		{
			return default(uint);
		}

		private static uint Mod1024(uint x)
		{
			return default(uint);
		}

		private static uint Mod512(uint x)
		{
			return default(uint);
		}

		private static uint Dim(uint x, uint y)
		{
			return default(uint);
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
	}
}
