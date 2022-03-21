namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
	public abstract class AsymmetricKeyParameter : ICipherParameters
	{
		private readonly bool privateKey;

		public bool IsPrivate
		{
			get
			{
				return default(bool);
			}
		}

		protected AsymmetricKeyParameter(bool privateKey)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected bool Equals(AsymmetricKeyParameter other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
