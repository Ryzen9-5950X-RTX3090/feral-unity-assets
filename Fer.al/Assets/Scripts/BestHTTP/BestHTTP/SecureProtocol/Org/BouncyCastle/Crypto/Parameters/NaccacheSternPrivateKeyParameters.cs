using System;
using System.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class NaccacheSternPrivateKeyParameters : NaccacheSternKeyParameters
	{
		private readonly BigInteger phiN;

		private readonly IList smallPrimes;

		public BigInteger PhiN
		{
			get
			{
				return null;
			}
		}

		public ArrayList SmallPrimes
		{
			get
			{
				return null;
			}
		}

		public IList SmallPrimesList
		{
			get
			{
				return null;
			}
		}

		[Obsolete]
		public NaccacheSternPrivateKeyParameters(BigInteger g, BigInteger n, int lowerSigmaBound, ArrayList smallPrimes, BigInteger phiN)
		{
		}

		public NaccacheSternPrivateKeyParameters(BigInteger g, BigInteger n, int lowerSigmaBound, IList smallPrimes, BigInteger phiN)
		{
		}
	}
}
