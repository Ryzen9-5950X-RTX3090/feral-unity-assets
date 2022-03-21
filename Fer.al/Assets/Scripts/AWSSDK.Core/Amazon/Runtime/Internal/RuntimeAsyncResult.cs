using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class RuntimeAsyncResult : IAsyncResult, IDisposable
	{
		private object _lockObj;

		private ManualResetEvent _waitHandle;

		private bool _disposed;

		private bool _callbackInvoked;

		private ILogger _logger;

		private AsyncCallback AsyncCallback
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

		public Exception Exception
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

		public AmazonWebServiceResponse Response
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

		public AmazonWebServiceRequest Request
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

		public Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> Action
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

		public AsyncOptions AsyncOptions
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

		public RuntimeAsyncResult(AsyncCallback asyncCallback, object asyncState)
		{
		}

		internal void SignalWaitHandle()
		{
		}

		internal void HandleException(Exception exception)
		{
		}

		public void InvokeCallback()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}
	}
}
