using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Amazon.Runtime.Internal
{
	internal class SimpleAsyncResult : IAsyncResult
	{
		public object AsyncState
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				return null;
			}
		}

		public bool CompletedSynchronously
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		public SimpleAsyncResult(object state)
		{
		}
	}
}
