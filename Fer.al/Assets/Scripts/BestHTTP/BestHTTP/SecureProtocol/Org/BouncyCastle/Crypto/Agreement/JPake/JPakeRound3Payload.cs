using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
{
	public class JPakeRound3Payload
	{
		private readonly string participantId;

		private readonly BigInteger macTag;

		public virtual string ParticipantId
		{
			get
			{
				return null;
			}
		}

		public virtual BigInteger MacTag
		{
			get
			{
				return null;
			}
		}

		public JPakeRound3Payload(string participantId, BigInteger magTag)
		{
		}
	}
}
