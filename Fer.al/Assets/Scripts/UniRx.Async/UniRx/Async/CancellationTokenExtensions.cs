using System;
using System.Threading;

namespace UniRx.Async
{
	public static class CancellationTokenExtensions
	{
		private static readonly Action<object> cancellationTokenCallback;

		public static ValueTuple<UniTask, CancellationTokenRegistration> ToUniTask(this CancellationToken cts)
		{
			return default(ValueTuple<UniTask, CancellationTokenRegistration>);
		}

		private static void Callback(object state)
		{
		}

		public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(this CancellationToken cancellationToken, Action callback)
		{
			return default(CancellationTokenRegistration);
		}

		public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(this CancellationToken cancellationToken, Action<object> callback, object state)
		{
			return default(CancellationTokenRegistration);
		}
	}
}
