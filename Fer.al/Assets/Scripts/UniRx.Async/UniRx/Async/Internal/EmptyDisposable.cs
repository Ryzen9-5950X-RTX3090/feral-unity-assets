using System;

namespace UniRx.Async.Internal
{
	internal class EmptyDisposable : IDisposable
	{
		public static EmptyDisposable Instance;

		private EmptyDisposable()
		{
		}

		public void Dispose()
		{
		}
	}
}
