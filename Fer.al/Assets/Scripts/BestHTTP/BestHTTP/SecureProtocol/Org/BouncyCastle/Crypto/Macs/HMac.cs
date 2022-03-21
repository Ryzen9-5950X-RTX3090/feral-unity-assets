using BestHTTP.PlatformSupport.IL2CPP;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs
{
	[Il2CppEagerStaticClassConstruction]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public sealed class HMac : IMac
	{
		private const byte IPAD = 54;

		private const byte OPAD = 92;

		private readonly IDigest digest;

		private readonly int digestSize;

		private readonly int blockLength;

		private IMemoable ipadState;

		private IMemoable opadState;

		private readonly byte[] inputPad;

		private readonly byte[] outputBuf;

		public string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public HMac(IDigest digest)
		{
		}

		public IDigest GetUnderlyingDigest()
		{
			return null;
		}

		public void Init(ICipherParameters parameters)
		{
		}

		public int GetMacSize()
		{
			return default(int);
		}

		public void Update(byte input)
		{
		}

		public void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		public int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}

		public void Reset()
		{
		}

		private static void XorPad(byte[] pad, int len, byte n)
		{
		}
	}
}
