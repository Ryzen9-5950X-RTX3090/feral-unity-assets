using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
	public class ChaCha20Poly1305 : IAeadCipher
	{
		private enum State
		{
			Uninitialized,
			EncInit,
			EncAad,
			EncData,
			EncFinal,
			DecInit,
			DecAad,
			DecData,
			DecFinal
		}

		private const int BufSize = 64;

		private const int KeySize = 32;

		private const int NonceSize = 12;

		private const int MacSize = 16;

		private static readonly byte[] Zeroes;

		private const ulong AadLimit = ulong.MaxValue;

		private const ulong DataLimit = 274877906880uL;

		private readonly ChaCha7539Engine mChacha20;

		private readonly IMac mPoly1305;

		private readonly byte[] mKey;

		private readonly byte[] mNonce;

		private readonly byte[] mBuf;

		private readonly byte[] mMac;

		private byte[] mInitialAad;

		private ulong mAadCount;

		private ulong mDataCount;

		private State mState;

		private int mBufPos;

		public virtual string AlgorithmName
		{
			get
			{
				return null;
			}
		}

		public ChaCha20Poly1305()
		{
		}

		public ChaCha20Poly1305(IMac poly1305)
		{
		}

		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		public virtual int GetOutputSize(int len)
		{
			return default(int);
		}

		public virtual int GetUpdateOutputSize(int len)
		{
			return default(int);
		}

		public virtual void ProcessAadByte(byte input)
		{
		}

		public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
		{
		}

		public virtual int ProcessByte(byte input, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public virtual int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public virtual int DoFinal(byte[] outBytes, int outOff)
		{
			return default(int);
		}

		public virtual byte[] GetMac()
		{
			return null;
		}

		public virtual void Reset()
		{
		}

		private void CheckAad()
		{
		}

		private void CheckData()
		{
		}

		private void FinishAad(State nextState)
		{
		}

		private void FinishData(State nextState)
		{
		}

		private ulong IncrementCount(ulong count, uint increment, ulong limit)
		{
			return default(ulong);
		}

		private void InitMac()
		{
		}

		private void PadMac(ulong count)
		{
		}

		private void ProcessData(byte[] inBytes, int inOff, int inLen, byte[] outBytes, int outOff)
		{
		}

		private void Reset(bool clearMac, bool resetCipher)
		{
		}
	}
}
