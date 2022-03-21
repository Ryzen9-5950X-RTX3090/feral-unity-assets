using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math
{
	public abstract class Primes
	{
		public class MROutput
		{
			private readonly bool mProvablyComposite;

			private readonly BigInteger mFactor;

			public BigInteger Factor
			{
				get
				{
					return null;
				}
			}

			public bool IsProvablyComposite
			{
				get
				{
					return default(bool);
				}
			}

			public bool IsNotPrimePower
			{
				get
				{
					return default(bool);
				}
			}

			internal static MROutput ProbablyPrime()
			{
				return null;
			}

			internal static MROutput ProvablyCompositeWithFactor(BigInteger factor)
			{
				return null;
			}

			internal static MROutput ProvablyCompositeNotPrimePower()
			{
				return null;
			}

			private MROutput(bool provablyComposite, BigInteger factor)
			{
			}
		}

		public class STOutput
		{
			private readonly BigInteger mPrime;

			private readonly byte[] mPrimeSeed;

			private readonly int mPrimeGenCounter;

			public BigInteger Prime
			{
				get
				{
					return null;
				}
			}

			public byte[] PrimeSeed
			{
				get
				{
					return null;
				}
			}

			public int PrimeGenCounter
			{
				get
				{
					return default(int);
				}
			}

			internal STOutput(BigInteger prime, byte[] primeSeed, int primeGenCounter)
			{
			}
		}

		public static readonly int SmallFactorLimit;

		private static readonly BigInteger One;

		private static readonly BigInteger Two;

		private static readonly BigInteger Three;

		public static STOutput GenerateSTRandomPrime(IDigest hash, int length, byte[] inputSeed)
		{
			return null;
		}

		public static MROutput EnhancedMRProbablePrimeTest(BigInteger candidate, SecureRandom random, int iterations)
		{
			return null;
		}

		public static bool HasAnySmallFactors(BigInteger candidate)
		{
			return default(bool);
		}

		public static bool IsMRProbablePrime(BigInteger candidate, SecureRandom random, int iterations)
		{
			return default(bool);
		}

		public static bool IsMRProbablePrimeToBase(BigInteger candidate, BigInteger baseValue)
		{
			return default(bool);
		}

		private static void CheckCandidate(BigInteger n, string name)
		{
		}

		private static bool ImplHasAnySmallFactors(BigInteger x)
		{
			return default(bool);
		}

		private static bool ImplMRProbablePrimeToBase(BigInteger w, BigInteger wSubOne, BigInteger m, int a, BigInteger b)
		{
			return default(bool);
		}

		private static STOutput ImplSTRandomPrime(IDigest d, int length, byte[] primeSeed)
		{
			return null;
		}

		private static uint Extract32(byte[] bs)
		{
			return default(uint);
		}

		private static void Hash(IDigest d, byte[] input, byte[] output, int outPos)
		{
		}

		private static BigInteger HashGen(IDigest d, byte[] seed, int count)
		{
			return null;
		}

		private static void Inc(byte[] seed, int c)
		{
		}

		private static bool IsPrime32(uint x)
		{
			return default(bool);
		}
	}
}
