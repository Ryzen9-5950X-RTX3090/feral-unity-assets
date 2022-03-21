using System;
using System.Runtime.CompilerServices;
using BestHTTP.Futures;

namespace BestHTTP.SignalRCore
{
	public sealed class DownStreamItemController<TResult> : IFuture<TResult>, IDisposable
	{
		public readonly long invocationId;

		public readonly HubConnection hubConnection;

		public readonly IFuture<TResult> future;

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

		public DownStreamItemController(HubConnection hub, long iId, IFuture<TResult> future)
		{
		}

		public void Cancel()
		{
		}

		public void Dispose()
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
