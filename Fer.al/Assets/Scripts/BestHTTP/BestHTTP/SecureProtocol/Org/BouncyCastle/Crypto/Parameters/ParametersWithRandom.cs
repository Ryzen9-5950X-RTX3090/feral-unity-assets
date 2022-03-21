using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class ParametersWithRandom : ICipherParameters
	{
		private readonly ICipherParameters parameters;

		private readonly SecureRandom random;

		public SecureRandom Random
		{
			get
			{
				return null;
			}
		}

		public ICipherParameters Parameters
		{
			get
			{
				return null;
			}
		}

		public ParametersWithRandom(ICipherParameters parameters, SecureRandom random)
		{
		}

		public ParametersWithRandom(ICipherParameters parameters)
		{
		}

		public SecureRandom GetRandom()
		{
			return null;
		}
	}
}
