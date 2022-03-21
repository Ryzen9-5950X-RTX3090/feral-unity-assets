using System.IO;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class ServerSrpParams
	{
		protected BigInteger m_N;

		protected BigInteger m_g;

		protected BigInteger m_B;

		protected byte[] m_s;

		public virtual BigInteger B
		{
			get
			{
				return null;
			}
		}

		public virtual BigInteger G
		{
			get
			{
				return null;
			}
		}

		public virtual BigInteger N
		{
			get
			{
				return null;
			}
		}

		public virtual byte[] S
		{
			get
			{
				return null;
			}
		}

		public ServerSrpParams(BigInteger N, BigInteger g, byte[] s, BigInteger B)
		{
		}

		public virtual void Encode(Stream output)
		{
		}

		public static ServerSrpParams Parse(Stream input)
		{
			return null;
		}
	}
}
