using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto
{
	public interface IRsa
	{
		void Init(bool forEncryption, ICipherParameters parameters);

		int GetInputBlockSize();

		int GetOutputBlockSize();

		BigInteger ConvertInput(byte[] buf, int off, int len);

		BigInteger ProcessBlock(BigInteger input);

		byte[] ConvertOutput(BigInteger result);
	}
}
