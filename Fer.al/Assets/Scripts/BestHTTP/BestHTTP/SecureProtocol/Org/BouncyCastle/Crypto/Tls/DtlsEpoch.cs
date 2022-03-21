namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	internal class DtlsEpoch
	{
		private readonly DtlsReplayWindow mReplayWindow;

		private readonly int mEpoch;

		private readonly TlsCipher mCipher;

		private long mSequenceNumber;

		internal TlsCipher Cipher
		{
			get
			{
				return null;
			}
		}

		internal int Epoch
		{
			get
			{
				return default(int);
			}
		}

		internal DtlsReplayWindow ReplayWindow
		{
			get
			{
				return null;
			}
		}

		internal long SequenceNumber
		{
			get
			{
				return default(long);
			}
		}

		internal DtlsEpoch(int epoch, TlsCipher cipher)
		{
		}

		internal long AllocateSequenceNumber()
		{
			return default(long);
		}
	}
}
