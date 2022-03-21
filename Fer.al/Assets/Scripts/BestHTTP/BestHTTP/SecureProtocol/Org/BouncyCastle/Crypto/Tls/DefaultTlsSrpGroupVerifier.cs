using System.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class DefaultTlsSrpGroupVerifier : TlsSrpGroupVerifier
	{
		protected static readonly IList DefaultGroups;

		protected readonly IList mGroups;

		static DefaultTlsSrpGroupVerifier()
		{
		}

		public DefaultTlsSrpGroupVerifier()
		{
		}

		public DefaultTlsSrpGroupVerifier(IList groups)
		{
		}

		public virtual bool Accept(Srp6GroupParameters group)
		{
			return default(bool);
		}

		protected virtual bool AreGroupsEqual(Srp6GroupParameters a, Srp6GroupParameters b)
		{
			return default(bool);
		}

		protected virtual bool AreParametersEqual(BigInteger a, BigInteger b)
		{
			return default(bool);
		}
	}
}
