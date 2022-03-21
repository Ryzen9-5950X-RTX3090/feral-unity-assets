using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Cms
{
	public class PasswordRecipientInformation : RecipientInformation
	{
		private readonly PasswordRecipientInfo info;

		public virtual AlgorithmIdentifier KeyDerivationAlgorithm
		{
			get
			{
				return null;
			}
		}

		internal PasswordRecipientInformation(PasswordRecipientInfo info, CmsSecureReadable secureReadable)
		{
		}

		public override CmsTypedStream GetContentStream(ICipherParameters key)
		{
			return null;
		}
	}
}
