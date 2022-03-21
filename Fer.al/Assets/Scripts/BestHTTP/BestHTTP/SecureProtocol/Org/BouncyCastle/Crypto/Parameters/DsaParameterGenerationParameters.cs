using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class DsaParameterGenerationParameters
	{
		public const int DigitalSignatureUsage = 1;

		public const int KeyEstablishmentUsage = 2;

		private readonly int l;

		private readonly int n;

		private readonly int certainty;

		private readonly SecureRandom random;

		private readonly int usageIndex;

		public virtual int L
		{
			get
			{
				return default(int);
			}
		}

		public virtual int N
		{
			get
			{
				return default(int);
			}
		}

		public virtual int UsageIndex
		{
			get
			{
				return default(int);
			}
		}

		public virtual int Certainty
		{
			get
			{
				return default(int);
			}
		}

		public virtual SecureRandom Random
		{
			get
			{
				return null;
			}
		}

		public DsaParameterGenerationParameters(int L, int N, int certainty, SecureRandom random)
		{
		}

		public DsaParameterGenerationParameters(int L, int N, int certainty, SecureRandom random, int usageIndex)
		{
		}
	}
}
