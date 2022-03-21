using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings
{
	public class TbcPadding : IBlockCipherPadding
	{
		public string PaddingName
		{
			get
			{
				return null;
			}
		}

		public virtual void Init(SecureRandom random)
		{
		}

		public virtual int AddPadding(byte[] input, int inOff)
		{
			return default(int);
		}

		public virtual int PadCount(byte[] input)
		{
			return default(int);
		}
	}
}
