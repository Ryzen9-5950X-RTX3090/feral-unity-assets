using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	public class Gost3411_2012_256Digest : Gost3411_2012Digest
	{
		private static readonly byte[] IV;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public Gost3411_2012_256Digest()
		{
		}

		public Gost3411_2012_256Digest(Gost3411_2012_256Digest other)
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

		public override IMemoable Copy()
		{
			return null;
		}
	}
}
