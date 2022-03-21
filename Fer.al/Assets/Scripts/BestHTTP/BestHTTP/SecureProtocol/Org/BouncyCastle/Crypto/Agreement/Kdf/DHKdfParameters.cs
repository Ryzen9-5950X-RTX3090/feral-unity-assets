using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
{
	public class DHKdfParameters : IDerivationParameters
	{
		private readonly DerObjectIdentifier algorithm;

		private readonly int keySize;

		private readonly byte[] z;

		private readonly byte[] extraInfo;

		public DerObjectIdentifier Algorithm
		{
			get
			{
				return null;
			}
		}

		public int KeySize
		{
			get
			{
				return default(int);
			}
		}

		public DHKdfParameters(DerObjectIdentifier algorithm, int keySize, byte[] z)
		{
		}

		public DHKdfParameters(DerObjectIdentifier algorithm, int keySize, byte[] z, byte[] extraInfo)
		{
		}

		public byte[] GetZ()
		{
			return null;
		}

		public byte[] GetExtraInfo()
		{
			return null;
		}
	}
}
