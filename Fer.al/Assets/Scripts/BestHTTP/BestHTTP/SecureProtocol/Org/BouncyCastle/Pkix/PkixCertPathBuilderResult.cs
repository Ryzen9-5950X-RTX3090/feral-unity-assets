using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Pkix
{
	public class PkixCertPathBuilderResult : PkixCertPathValidatorResult
	{
		private PkixCertPath certPath;

		public PkixCertPath CertPath
		{
			get
			{
				return null;
			}
		}

		public PkixCertPathBuilderResult(PkixCertPath certPath, TrustAnchor trustAnchor, PkixPolicyNode policyTree, AsymmetricKeyParameter subjectPublicKey)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
