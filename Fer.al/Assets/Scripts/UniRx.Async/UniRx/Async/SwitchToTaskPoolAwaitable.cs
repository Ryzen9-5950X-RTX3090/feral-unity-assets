using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UniRx.Async
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct SwitchToTaskPoolAwaitable
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private static readonly Action<object> switchToCallback;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public void GetResult()
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}

			private static void Callback(object state)
			{
			}
		}

		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}
	}
}
