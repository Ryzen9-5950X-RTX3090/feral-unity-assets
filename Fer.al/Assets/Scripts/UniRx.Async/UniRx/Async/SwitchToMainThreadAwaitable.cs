using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UniRx.Async
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct SwitchToMainThreadAwaitable
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
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
		}

		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}
	}
}
