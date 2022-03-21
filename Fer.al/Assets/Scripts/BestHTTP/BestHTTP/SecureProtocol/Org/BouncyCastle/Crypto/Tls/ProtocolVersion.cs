namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public sealed class ProtocolVersion
	{
		public static readonly ProtocolVersion SSLv3;

		public static readonly ProtocolVersion TLSv10;

		public static readonly ProtocolVersion TLSv11;

		public static readonly ProtocolVersion TLSv12;

		public static readonly ProtocolVersion DTLSv10;

		public static readonly ProtocolVersion DTLSv12;

		private readonly int version;

		private readonly string name;

		public int FullVersion
		{
			get
			{
				return default(int);
			}
		}

		public int MajorVersion
		{
			get
			{
				return default(int);
			}
		}

		public int MinorVersion
		{
			get
			{
				return default(int);
			}
		}

		public bool IsDtls
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsSsl
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsTls
		{
			get
			{
				return default(bool);
			}
		}

		private ProtocolVersion(int v, string name)
		{
		}

		public ProtocolVersion GetEquivalentTLSVersion()
		{
			return null;
		}

		public bool IsEqualOrEarlierVersionOf(ProtocolVersion version)
		{
			return default(bool);
		}

		public bool IsLaterVersionOf(ProtocolVersion version)
		{
			return default(bool);
		}

		public override bool Equals(object other)
		{
			return default(bool);
		}

		public bool Equals(ProtocolVersion other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static ProtocolVersion Get(int major, int minor)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private static ProtocolVersion GetUnknownVersion(int major, int minor, string prefix)
		{
			return null;
		}
	}
}
