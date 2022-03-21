using BestHTTP.PlatformSupport.IL2CPP;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	[Il2CppEagerStaticClassConstruction]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public sealed class ChaChaEngine : Salsa20Engine
	{
		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public ChaChaEngine()
		{
		}

		public ChaChaEngine(int rounds)
		{
		}

		protected override void AdvanceCounter()
		{
		}

		protected override void ResetCounter()
		{
		}

		protected override void SetKey(byte[] keyBytes, byte[] ivBytes)
		{
		}

		protected override void GenerateKeyStream(byte[] output)
		{
		}

		internal static void ChachaCore(int rounds, uint[] input, uint[] x)
		{
		}
	}
}
