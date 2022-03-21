using System.Collections;
using System.IO;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	internal class DtlsReliableHandshake
	{
		internal class Message
		{
			private readonly int mMessageSeq;

			private readonly byte mMsgType;

			private readonly byte[] mBody;

			public int Seq
			{
				get
				{
					return default(int);
				}
			}

			public byte Type
			{
				get
				{
					return default(byte);
				}
			}

			public byte[] Body
			{
				get
				{
					return null;
				}
			}

			internal Message(int message_seq, byte msg_type, byte[] body)
			{
			}
		}

		internal class RecordLayerBuffer : MemoryStream
		{
			internal RecordLayerBuffer(int size)
			{
			}

			internal void SendToRecordLayer(DtlsRecordLayer recordLayer)
			{
			}
		}

		internal class Retransmit : DtlsHandshakeRetransmit
		{
			private readonly DtlsReliableHandshake mOuter;

			internal Retransmit(DtlsReliableHandshake outer)
			{
			}

			public void ReceivedHandshakeRecord(int epoch, byte[] buf, int off, int len)
			{
			}
		}

		private const int MaxReceiveAhead = 16;

		private const int MessageHeaderLength = 12;

		private readonly DtlsRecordLayer mRecordLayer;

		private TlsHandshakeHash mHandshakeHash;

		private IDictionary mCurrentInboundFlight;

		private IDictionary mPreviousInboundFlight;

		private IList mOutboundFlight;

		private bool mSending;

		private int mMessageSeq;

		private int mNextReceiveSeq;

		internal TlsHandshakeHash HandshakeHash
		{
			get
			{
				return null;
			}
		}

		internal DtlsReliableHandshake(TlsContext context, DtlsRecordLayer transport)
		{
		}

		internal void NotifyHelloComplete()
		{
		}

		internal TlsHandshakeHash PrepareToFinish()
		{
			return null;
		}

		internal void SendMessage(byte msg_type, byte[] body)
		{
		}

		internal byte[] ReceiveMessageBody(byte msg_type)
		{
			return null;
		}

		internal Message ReceiveMessage()
		{
			return null;
		}

		internal void Finish()
		{
		}

		internal void ResetHandshakeMessagesDigest()
		{
		}

		private int BackOff(int timeoutMillis)
		{
			return default(int);
		}

		private void CheckInboundFlight()
		{
		}

		private Message GetPendingMessage()
		{
			return null;
		}

		private void PrepareInboundFlight(IDictionary nextFlight)
		{
		}

		private bool ProcessRecord(int windowSize, int epoch, byte[] buf, int off, int len)
		{
			return default(bool);
		}

		private void ResendOutboundFlight()
		{
		}

		private Message UpdateHandshakeMessagesDigest(Message message)
		{
			return null;
		}

		private void WriteMessage(Message message)
		{
		}

		private void WriteHandshakeFragment(Message message, int fragment_offset, int fragment_length)
		{
		}

		private static bool CheckAll(IDictionary inboundFlight)
		{
			return default(bool);
		}

		private static void ResetAll(IDictionary inboundFlight)
		{
		}
	}
}
