using System.Collections;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	internal class DtlsReassembler
	{
		private class Range
		{
			private int mStart;

			private int mEnd;

			public int Start
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public int End
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			internal Range(int start, int end)
			{
			}
		}

		private readonly byte mMsgType;

		private readonly byte[] mBody;

		private readonly IList mMissing;

		internal byte MsgType
		{
			get
			{
				return default(byte);
			}
		}

		internal DtlsReassembler(byte msg_type, int length)
		{
		}

		internal byte[] GetBodyIfComplete()
		{
			return null;
		}

		internal void ContributeFragment(byte msg_type, int length, byte[] buf, int off, int fragment_offset, int fragment_length)
		{
		}

		internal void Reset()
		{
		}
	}
}
