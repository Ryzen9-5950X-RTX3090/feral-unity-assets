using System;
using System.Runtime.CompilerServices;
using BestHTTP.Futures;

namespace BestHTTP.SignalRCore
{
	public sealed class UpStreamItemController<TResult> : IUPloadItemController<TResult>, IDisposable, IFuture<TResult>
	{
		public readonly long invocationId;

		public readonly string[] streamingIds;

		public readonly HubConnection hubConnection;

		public readonly IFuture<TResult> future;

		private object[] streams;

		public string[] StreamingIDs
		{
			get
			{
				return null;
			}
		}

		public HubConnection Hub
		{
			get
			{
				return null;
			}
		}

		public FutureState state
		{
			get
			{
				return default(FutureState);
			}
		}

		public TResult value
		{
			get
			{
				return (TResult)null;
			}
		}

		public Exception error
		{
			get
			{
				return null;
			}
		}

		public bool IsFinished
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

		public bool IsCanceled
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

		public UpStreamItemController(HubConnection hub, long iId, string[] sIds, IFuture<TResult> future)
		{
		}

		public UploadChannel<TResult, T> GetUploadChannel<T>(int paramIdx)
		{
			return null;
		}

		public void UploadParam<T>(string streamId, T item)
		{
		}

		public void Finish()
		{
		}

		public void Cancel()
		{
		}

		void IDisposable.Dispose()
		{
		}

		public IFuture<TResult> OnItem(FutureValueCallback<TResult> callback)
		{
			return null;
		}

		public IFuture<TResult> OnSuccess(FutureValueCallback<TResult> callback)
		{
			return null;
		}

		public IFuture<TResult> OnError(FutureErrorCallback callback)
		{
			return null;
		}

		public IFuture<TResult> OnComplete(FutureCallback<TResult> callback)
		{
			return null;
		}
	}
}
