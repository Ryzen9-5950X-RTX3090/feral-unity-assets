namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class ElGamalKeyParameters : AsymmetricKeyParameter
	{
		private readonly ElGamalParameters parameters;

		public ElGamalParameters Parameters
		{
			get
			{
				return null;
			}
		}

		protected ElGamalKeyParameters(bool isPrivate, ElGamalParameters parameters)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected bool Equals(ElGamalKeyParameters other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
