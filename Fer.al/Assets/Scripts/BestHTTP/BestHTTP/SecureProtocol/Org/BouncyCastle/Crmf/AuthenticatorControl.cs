using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crmf
{
	public class AuthenticatorControl : IControl
	{
		private static readonly DerObjectIdentifier type;

		private readonly DerUtf8String token;

		public DerObjectIdentifier Type
		{
			get
			{
				return null;
			}
		}

		public Asn1Encodable Value
		{
			get
			{
				return null;
			}
		}

		public AuthenticatorControl(DerUtf8String token)
		{
		}

		public AuthenticatorControl(string token)
		{
		}
	}
}
