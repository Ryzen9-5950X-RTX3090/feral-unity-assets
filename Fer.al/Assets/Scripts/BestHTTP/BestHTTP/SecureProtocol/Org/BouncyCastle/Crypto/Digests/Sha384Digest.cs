using BestHTTP.PlatformSupport.IL2CPP;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	[Il2CppEagerStaticClassConstruction]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public class Sha384Digest : LongDigest
	{
		private const int DigestLength = 48;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public Sha384Digest()
		{
		}

		public Sha384Digest(Sha384Digest t)
		{
		}

		public override int GetDigestSize()
		{
			return default(int);
		}

		public override int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}

		public override void Reset()
		{
		}

		public override IMemoable Copy()
		{
			return null;
		}

		public override void Reset(IMemoable other)
		{
		}
	}
}
