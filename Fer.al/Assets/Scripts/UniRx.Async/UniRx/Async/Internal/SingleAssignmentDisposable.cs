using System;

namespace UniRx.Async.Internal
{
	internal sealed class SingleAssignmentDisposable : IDisposable
	{
		private readonly object gate;

		private IDisposable current;

		private bool disposed;

		public bool IsDisposed
		{
			get
			{
				return default(bool);
			}
		}

		public IDisposable Disposable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Dispose()
		{
		}
	}
}
