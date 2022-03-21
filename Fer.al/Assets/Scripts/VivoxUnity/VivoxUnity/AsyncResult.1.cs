using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace VivoxUnity
{
	public class AsyncResult<T> : IAsyncResult, IDisposable
	{
		private EventWaitHandle _waitHandle;

		private Exception _exception;

		private T _result;

		public T Result
		{
			get
			{
				return (T)null;
			}
			private set
			{
			}
		}

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

		public AsyncResult(AsyncCallback callback)
		{
		}

		public void SetComplete(T result)
		{
		}

		public void SetComplete(Exception exception)
		{
		}

		public void SetCompletedSynchronously(T result)
		{
		}

		public void Dispose()
		{
		}
	}
}
