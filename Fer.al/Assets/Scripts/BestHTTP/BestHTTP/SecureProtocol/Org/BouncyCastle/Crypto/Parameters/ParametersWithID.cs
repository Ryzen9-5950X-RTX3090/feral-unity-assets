namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
	public class ParametersWithID : ICipherParameters
	{
		private readonly ICipherParameters parameters;

		private readonly byte[] id;

		public ICipherParameters Parameters
		{
			get
			{
				return null;
			}
		}

		public ParametersWithID(ICipherParameters parameters, byte[] id)
		{
		}

		public ParametersWithID(ICipherParameters parameters, byte[] id, int idOff, int idLen)
		{
		}

		public byte[] GetID()
		{
			return null;
		}
	}
}
