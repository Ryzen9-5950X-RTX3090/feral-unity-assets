using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9
{
	public abstract class X9IntegerConverter
	{
		public static int GetByteLength(ECFieldElement fe)
		{
			return default(int);
		}

		public static int GetByteLength(ECCurve c)
		{
			return default(int);
		}

		public static byte[] IntegerToBytes(BigInteger s, int qLength)
		{
			return null;
		}
	}
}
