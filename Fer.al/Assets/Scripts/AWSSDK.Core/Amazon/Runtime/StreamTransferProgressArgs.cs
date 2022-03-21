using System;

namespace Amazon.Runtime
{
	public class StreamTransferProgressArgs : EventArgs
	{
		private long _incrementTransferred;

		private long _total;

		private long _transferred;

		public int PercentDone
		{
			get
			{
				return default(int);
			}
		}

		public long IncrementTransferred
		{
			get
			{
				return default(long);
			}
		}

		public long TransferredBytes
		{
			get
			{
				return default(long);
			}
		}

		public long TotalBytes
		{
			get
			{
				return default(long);
			}
		}

		public StreamTransferProgressArgs(long incrementTransferred, long transferred, long total)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
