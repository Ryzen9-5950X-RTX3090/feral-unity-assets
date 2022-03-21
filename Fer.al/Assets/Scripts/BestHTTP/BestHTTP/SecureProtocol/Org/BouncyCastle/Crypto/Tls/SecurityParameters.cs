namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public class SecurityParameters
	{
		internal int entity;

		internal int cipherSuite;

		internal byte compressionAlgorithm;

		internal int prfAlgorithm;

		internal int verifyDataLength;

		internal byte[] masterSecret;

		internal byte[] clientRandom;

		internal byte[] serverRandom;

		internal byte[] sessionHash;

		internal byte[] pskIdentity;

		internal byte[] srpIdentity;

		internal short maxFragmentLength;

		internal bool truncatedHMac;

		internal bool encryptThenMac;

		internal bool extendedMasterSecret;

		public virtual int Entity
		{
			get
			{
				return default(int);
			}
		}

		public virtual int CipherSuite
		{
			get
			{
				return default(int);
			}
		}

		public virtual byte CompressionAlgorithm
		{
			get
			{
				return default(byte);
			}
		}

		public virtual int PrfAlgorithm
		{
			get
			{
				return default(int);
			}
		}

		public virtual int VerifyDataLength
		{
			get
			{
				return default(int);
			}
		}

		public virtual byte[] MasterSecret
		{
			get
			{
				return null;
			}
		}

		public virtual byte[] ClientRandom
		{
			get
			{
				return null;
			}
		}

		public virtual byte[] ServerRandom
		{
			get
			{
				return null;
			}
		}

		public virtual byte[] SessionHash
		{
			get
			{
				return null;
			}
		}

		public virtual byte[] PskIdentity
		{
			get
			{
				return null;
			}
		}

		public virtual byte[] SrpIdentity
		{
			get
			{
				return null;
			}
		}

		public virtual bool IsExtendedMasterSecret
		{
			get
			{
				return default(bool);
			}
		}

		internal virtual void Clear()
		{
		}
	}
}
