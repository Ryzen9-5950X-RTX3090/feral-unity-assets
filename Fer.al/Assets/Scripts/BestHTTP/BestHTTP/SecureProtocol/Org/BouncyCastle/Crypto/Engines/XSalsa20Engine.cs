namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
	public class XSalsa20Engine : Salsa20Engine
	{
		public override string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		protected override int NonceSize
		{
			get
			{
				return default(int);
			}
		}

		protected override void SetKey(byte[] keyBytes, byte[] ivBytes)
		{
		}
	}
}
