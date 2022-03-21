using BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
	public class Gost3411_2012_512Digest : Gost3411_2012Digest
	{
		private static readonly byte[] IV;

		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public Gost3411_2012_512Digest()
		{
		}

		public Gost3411_2012_512Digest(Gost3411_2012_512Digest other)
		{
		}

		public override int GetDigestSize()
		{
			return default(int);
		}

		public override IMemoable Copy()
		{
			return null;
		}
	}
}
