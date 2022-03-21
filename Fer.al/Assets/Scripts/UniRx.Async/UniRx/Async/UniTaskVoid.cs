using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async.CompilerServices;

namespace UniRx.Async
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[AsyncMethodBuilder(typeof(AsyncUniTaskVoidMethodBuilder))]
	public struct UniTaskVoid
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			[DebuggerHidden]
			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			[DebuggerHidden]
			public void GetResult()
			{
			}

			[DebuggerHidden]
			public void OnCompleted(Action continuation)
			{
			}

			[DebuggerHidden]
			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		public void Forget()
		{
		}

		[DebuggerHidden]
		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}
	}
}
