using BestHTTP.PlatformSupport.IL2CPP;
using BestHTTP.PlatformSupport.Memory;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	[Il2CppEagerStaticClassConstruction]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public sealed class TlsMac
	{
		private readonly TlsContext context;

		private readonly byte[] secret;

		private readonly IMac mac;

		private readonly int digestBlockSize;

		private readonly int digestOverhead;

		private readonly int macLength;

		public byte[] MacSecret
		{
			get
			{
				return null;
			}
		}

		public int Size
		{
			get
			{
				return default(int);
			}
		}

		public TlsMac(TlsContext context, IDigest digest, byte[] key, int keyOff, int keyLen)
		{
		}

		public BufferSegment CalculateMac(long seqNo, byte type, byte[] message, int offset, int length)
		{
			return default(BufferSegment);
		}

		public BufferSegment CalculateMacConstantTime(long seqNo, byte type, byte[] message, int offset, int length, int fullLength, byte[] dummyData)
		{
			return default(BufferSegment);
		}

		protected int GetDigestBlockCount(int inputLength)
		{
			return default(int);
		}

		protected BufferSegment Truncate(BufferSegment bs)
		{
			return default(BufferSegment);
		}
	}
}
