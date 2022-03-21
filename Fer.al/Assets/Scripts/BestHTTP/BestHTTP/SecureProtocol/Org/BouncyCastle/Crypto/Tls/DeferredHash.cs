using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	internal class DeferredHash : TlsHandshakeHash, IDigest
	{
		protected const int BUFFERING_HASH_LIMIT = 4;

		protected TlsContext mContext;

		private DigestInputBuffer mBuf;

		private IDictionary mHashes;

		private int mPrfHashAlgorithm;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		internal DeferredHash()
		{
		}

		private DeferredHash(byte prfHashAlgorithm, IDigest prfHash)
		{
		}

		public virtual void Init(TlsContext context)
		{
		}

		public virtual TlsHandshakeHash NotifyPrfDetermined()
		{
			return null;
		}

		public virtual void TrackHashAlgorithm(byte hashAlgorithm)
		{
		}

		public virtual void SealHashAlgorithms()
		{
		}

		public virtual TlsHandshakeHash StopTracking()
		{
			return null;
		}

		public virtual IDigest ForkPrfHash()
		{
			return null;
		}

		public virtual byte[] GetFinalHash(byte hashAlgorithm)
		{
			return null;
		}

		public virtual int GetByteLength()
		{
			return default(int);
		}

		public virtual int GetDigestSize()
		{
			return default(int);
		}

		public virtual void Update(byte input)
		{
		}

		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		public virtual int DoFinal(byte[] output, int outOff)
		{
			return default(int);
		}

		public virtual void Reset()
		{
		}

		protected virtual void CheckStopBuffering()
		{
		}

		protected virtual void CheckTrackingHash(byte hashAlgorithm)
		{
		}
	}
}
