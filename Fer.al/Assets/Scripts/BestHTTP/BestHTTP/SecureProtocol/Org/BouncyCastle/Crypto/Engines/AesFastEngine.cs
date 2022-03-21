using BestHTTP.PlatformSupport.IL2CPP;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	[Il2CppEagerStaticClassConstruction]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public sealed class AesFastEngine : IBlockCipher
	{
		private static readonly byte[] S;

		private static readonly byte[] Si;

		private static readonly byte[] rcon;

		private static readonly uint[] T0;

		private static readonly uint[] T1;

		private static readonly uint[] T2;

		private static readonly uint[] T3;

		private static readonly uint[] Tinv0;

		private static readonly uint[] Tinv1;

		private static readonly uint[] Tinv2;

		private static readonly uint[] Tinv3;

		private const uint m1 = 2155905152u;

		private const uint m2 = 2139062143u;

		private const uint m3 = 27u;

		private const uint m4 = 3233857728u;

		private const uint m5 = 1061109567u;

		private int ROUNDS;

		private uint[][] WorkingKey;

		private uint C0;

		private uint C1;

		private uint C2;

		private uint C3;

		private bool forEncryption;

		private const int BLOCK_SIZE = 16;

		public string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public bool IsPartialBlockOkay
		{
			get
			{
				return default(bool);
			}
		}

		private static uint Shift(uint r, int shift)
		{
			return default(uint);
		}

		private static uint FFmulX(uint x)
		{
			return default(uint);
		}

		private static uint FFmulX2(uint x)
		{
			return default(uint);
		}

		private static uint Inv_Mcol(uint x)
		{
			return default(uint);
		}

		private static uint SubWord(uint x)
		{
			return default(uint);
		}

		private uint[][] GenerateWorkingKey(byte[] key, bool forEncryption)
		{
			return null;
		}

		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public int GetBlockSize()
		{
			return default(int);
		}

		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return default(int);
		}

		public void Reset()
		{
		}

		private void UnPackBlock(byte[] input, int inOff)
		{
		}

		private void PackBlock(byte[] output, int outOff)
		{
		}
	}
}
