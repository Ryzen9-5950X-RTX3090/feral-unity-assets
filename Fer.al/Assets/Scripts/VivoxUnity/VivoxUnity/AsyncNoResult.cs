using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace VivoxUnity
{
	public class AsyncNoResult : IAsyncResult, IDisposable
	{
		private EventWaitHandle _waitHandle;

		private Exception _exception;

		public AsyncCallback Callback
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public object AsyncState
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
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
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsCompleted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AsyncNoResult(AsyncCallback callback)
		{
		}

		public void CheckForError()
		{
		}

		public void SetComplete()
		{
		}

		public void SetCompletedSynchronously()
		{
		}

		public void SetComplete(Exception exception)
		{
		}

		public void Dispose()
		{
		}
	}
}
