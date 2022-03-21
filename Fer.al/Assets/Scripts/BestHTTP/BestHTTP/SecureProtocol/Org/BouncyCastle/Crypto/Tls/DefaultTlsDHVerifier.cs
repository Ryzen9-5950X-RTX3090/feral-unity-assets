using System.Collections;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class DefaultTlsDHVerifier : TlsDHVerifier
	{
		public static readonly int DefaultMinimumPrimeBits;

		protected static readonly IList DefaultGroups;

		protected readonly IList mGroups;

		protected readonly int mMinimumPrimeBits;

		public virtual int MinimumPrimeBits
		{
			get
			{
				return default(int);
			}
		}

		private static void AddDefaultGroup(DHParameters dhParameters)
		{
		}

		static DefaultTlsDHVerifier()
		{
		}

		public DefaultTlsDHVerifier()
		{
		}

		public DefaultTlsDHVerifier(int minimumPrimeBits)
		{
		}

		public DefaultTlsDHVerifier(IList groups, int minimumPrimeBits)
		{
		}

		public virtual bool Accept(DHParameters dhParameters)
		{
			return default(bool);
		}

		protected virtual bool AreGroupsEqual(DHParameters a, DHParameters b)
		{
			return default(bool);
		}

		protected virtual bool AreParametersEqual(BigInteger a, BigInteger b)
		{
			return default(bool);
		}

		protected virtual bool CheckGroup(DHParameters dhParameters)
		{
			return default(bool);
		}

		protected virtual bool CheckMinimumPrimeBits(DHParameters dhParameters)
		{
			return default(bool);
		}
	}
}
