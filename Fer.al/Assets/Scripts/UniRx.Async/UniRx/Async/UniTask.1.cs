using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async.CompilerServices;

namespace UniRx.Async
{
	[AsyncMethodBuilder(typeof(AsyncUniTaskMethodBuilder<>))]
	public struct UniTask<T> : IEquatable<UniTask<T>>
	{
		private class IsCanceledAwaiter : IAwaiter<ValueTuple<bool, T>>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly IAwaiter<T> awaiter;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			public IsCanceledAwaiter(IAwaiter<T> awaiter)
			{
			}

			public ValueTuple<bool, T> GetResult()
			{
				return default(ValueTuple<bool, T>);
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}

			void IAwaiter.GetResult()
			{
			}
		}

		public struct Awaiter : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly UniTask<T> task;

			[DebuggerHidden]
			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			[DebuggerHidden]
			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			[DebuggerHidden]
			public Awaiter(UniTask<T> task)
			{
			}

			[DebuggerHidden]
			void IAwaiter.GetResult()
			{
			}

			[DebuggerHidden]
			public T GetResult()
			{
				return (T)null;
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

		private readonly T result;

		private readonly IAwaiter<T> awaiter;

		[DebuggerHidden]
		public AwaiterStatus Status
		{
			get
			{
				return default(AwaiterStatus);
			}
		}

		[DebuggerHidden]
		public bool IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerHidden]
		public T Result
		{
			get
			{
				return (T)null;
			}
		}

		[DebuggerHidden]
		public UniTask(T result)
		{
		}

		[DebuggerHidden]
		public UniTask(IAwaiter<T> awaiter)
		{
		}

		[DebuggerHidden]
		public UniTask(Func<UniTask<T>> factory)
		{
		}

		[DebuggerHidden]
		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}

		public UniTask<ValueTuple<bool, T>> SuppressCancellationThrow()
		{
			return default(UniTask<ValueTuple<bool, T>>);
		}

		public bool Equals(UniTask<T> other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator UniTask(UniTask<T> task)
		{
			return default(UniTask);
		}
	}
}
