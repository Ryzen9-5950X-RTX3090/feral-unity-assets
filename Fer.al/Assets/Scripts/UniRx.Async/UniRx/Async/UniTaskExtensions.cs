using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UniRx.Async.CompilerServices;

namespace UniRx.Async
{
	public static class UniTaskExtensions
	{
		private class ToCoroutineEnumerator : IEnumerator
		{
			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask>d__6 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask task;

				public ToCoroutineEnumerator <>4__this;

				private UniTask.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private bool completed;

			private UniTask task;

			private Action<Exception> exceptionHandler;

			private bool isStarted;

			private ExceptionDispatchInfo exception;

			public object Current
			{
				get
				{
					return null;
				}
			}

			public ToCoroutineEnumerator(UniTask task, Action<Exception> exceptionHandler)
			{
			}

			[AsyncStateMachine(typeof(<RunTask>d__6))]
			private UniTaskVoid RunTask(UniTask task)
			{
				return default(UniTaskVoid);
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			public void Reset()
			{
			}
		}

		private class ToCoroutineEnumerator<T> : IEnumerator
		{
			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask>d__8 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T> task;

				public ToCoroutineEnumerator<T> <>4__this;

				private UniTask<T>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private bool completed;

			private Action<T> resultHandler;

			private Action<Exception> exceptionHandler;

			private bool isStarted;

			private UniTask<T> task;

			private object current;

			private ExceptionDispatchInfo exception;

			public object Current
			{
				get
				{
					return null;
				}
			}

			public ToCoroutineEnumerator(UniTask<T> task, Action<T> resultHandler, Action<Exception> exceptionHandler)
			{
			}

			[AsyncStateMachine(typeof(ToCoroutineEnumerator<>.<RunTask>d__8))]
			private UniTaskVoid RunTask(UniTask<T> task)
			{
				return default(UniTaskVoid);
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			public void Reset()
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <Timeout>d__14<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<T> <>t__builder;

			public TimeSpan timeout;

			public bool ignoreTimeScale;

			public PlayerLoopTiming timeoutCheckTiming;

			public UniTask<T> task;

			public CancellationTokenSource taskCancellationTokenSource;

			private CancellationTokenSource <delayCancellationTokenSource>5__2;

			private UniTask<ValueTuple<bool, ValueTuple<bool, T>>>.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <TimeoutWithoutException>d__15 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<bool> <>t__builder;

			public UniTask task;

			public TimeSpan timeout;

			public bool ignoreTimeScale;

			public PlayerLoopTiming timeoutCheckTiming;

			public CancellationTokenSource taskCancellationTokenSource;

			private UniTask<ValueTuple<bool, AsyncUnit>>.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <TimeoutWithoutException>d__16<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<bool, T>> <>t__builder;

			public TimeSpan timeout;

			public bool ignoreTimeScale;

			public PlayerLoopTiming timeoutCheckTiming;

			public UniTask<T> task;

			public CancellationTokenSource taskCancellationTokenSource;

			private CancellationTokenSource <delayCancellationTokenSource>5__2;

			private UniTask<ValueTuple<bool, ValueTuple<bool, T>>>.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ForgetCore>d__19 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			public UniTask task;

			private UniTask.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ForgetCoreWithCatch>d__20 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			public UniTask task;

			public bool handleExceptionOnMainThread;

			public Action<Exception> exceptionHandler;

			private object <>7__wrap1;

			private int <>7__wrap2;

			private UniTask.Awaiter <>u__1;

			private Exception <ex>5__4;

			private SwitchToMainThreadAwaitable.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ForgetCore>d__23<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			public UniTask<T> task;

			private UniTask<T>.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ForgetCoreWithCatch>d__24<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			public UniTask<T> task;

			public bool handleExceptionOnMainThread;

			public Action<Exception> exceptionHandler;

			private object <>7__wrap1;

			private int <>7__wrap2;

			private UniTask<T>.Awaiter <>u__1;

			private Exception <ex>5__4;

			private SwitchToMainThreadAwaitable.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ContinueWith>d__25<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public Action<T> continuationFunction;

			public UniTask<T> task;

			private Action<T> <>7__wrap1;

			private UniTask<T>.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ContinueWith>d__26<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public Func<T, UniTask> continuationFunction;

			public UniTask<T> task;

			private Func<T, UniTask> <>7__wrap1;

			private UniTask<T>.Awaiter <>u__1;

			private UniTask.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ContinueWith>d__27<T, TR> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<TR> <>t__builder;

			public Func<T, TR> continuationFunction;

			public UniTask<T> task;

			private Func<T, TR> <>7__wrap1;

			private UniTask<T>.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ContinueWith>d__28<T, TR> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<TR> <>t__builder;

			public Func<T, UniTask<TR>> continuationFunction;

			public UniTask<T> task;

			private Func<T, UniTask<TR>> <>7__wrap1;

			private UniTask<T>.Awaiter <>u__1;

			private UniTask<TR>.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ContinueWith>d__29 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public UniTask task;

			public Action continuationFunction;

			private UniTask.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ContinueWith>d__30 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public UniTask task;

			public Func<UniTask> continuationFunction;

			private UniTask.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ContinueWith>d__31<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<T> <>t__builder;

			public UniTask task;

			public Func<T> continuationFunction;

			private UniTask.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ContinueWith>d__32<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<T> <>t__builder;

			public UniTask task;

			public Func<UniTask<T>> continuationFunction;

			private UniTask.Awaiter <>u__1;

			private UniTask<T>.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ConfigureAwait>d__33 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public Task task;

			public PlayerLoopTiming timing;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			private YieldAwaitable.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ConfigureAwait>d__34<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<T> <>t__builder;

			public Task<T> task;

			public PlayerLoopTiming timing;

			private T <v>5__2;

			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter <>u__1;

			private YieldAwaitable.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ConfigureAwait>d__35 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public UniTask task;

			public PlayerLoopTiming timing;

			private UniTask.Awaiter <>u__1;

			private YieldAwaitable.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ConfigureAwait>d__36<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<T> <>t__builder;

			public UniTask<T> task;

			public PlayerLoopTiming timing;

			private T <v>5__2;

			private UniTask<T>.Awaiter <>u__1;

			private YieldAwaitable.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <Unwrap>d__37<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<T> <>t__builder;

			public UniTask<UniTask<T>> task;

			private UniTask<UniTask<T>>.Awaiter <>u__1;

			private UniTask<T>.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <Unwrap>d__38<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public UniTask<UniTask> task;

			private UniTask<UniTask>.Awaiter <>u__1;

			private UniTask.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public static UniTask.Awaiter GetAwaiter(this IEnumerable<UniTask> tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask<T[]>.Awaiter GetAwaiter<T>(this IEnumerable<UniTask<T>> tasks)
		{
			return default(UniTask<T[]>.Awaiter);
		}

		public static UniTask<ValueTuple<T1, T2>>.Awaiter GetAwaiter<T1, T2>(this ValueTuple<UniTask<T1>, UniTask<T2>> tasks)
		{
			return default(UniTask<ValueTuple<T1, T2>>.Awaiter);
		}

		public static UniTask<ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>(this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>> tasks)
		{
			return default(UniTask<ValueTuple<T1, T2, T3>>);
		}

		public static UniTask<ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>> tasks)
		{
			return default(UniTask<ValueTuple<T1, T2, T3, T4>>);
		}

		public static UniTask<ValueTuple<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>(this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>> tasks)
		{
			return default(UniTask<ValueTuple<T1, T2, T3, T4, T5>>);
		}

		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>(this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>> tasks)
		{
			return default(UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>>);
		}

		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(this ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>> tasks)
		{
			return default(UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>);
		}

		public static UniTask<AsyncUnit> AsAsyncUnitUniTask(this UniTask task)
		{
			return default(UniTask<AsyncUnit>);
		}

		public static UniTask<T> AsUniTask<T>(this Task<T> task, bool useCurrentSynchronizationContext = true)
		{
			return default(UniTask<T>);
		}

		public static UniTask AsUniTask(this Task task, bool useCurrentSynchronizationContext = true)
		{
			return default(UniTask);
		}

		public static IEnumerator ToCoroutine<T>(this UniTask<T> task, [Optional] Action<T> resultHandler, [Optional] Action<Exception> exceptionHandler)
		{
			return null;
		}

		public static IEnumerator ToCoroutine(this UniTask task, [Optional] Action<Exception> exceptionHandler)
		{
			return null;
		}

		public static UniTask Timeout(this UniTask task, TimeSpan timeout, bool ignoreTimeScale = true, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, [Optional] CancellationTokenSource taskCancellationTokenSource)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<Timeout>d__14<>))]
		public static UniTask<T> Timeout<T>(this UniTask<T> task, TimeSpan timeout, bool ignoreTimeScale = true, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, [Optional] CancellationTokenSource taskCancellationTokenSource)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(<TimeoutWithoutException>d__15))]
		public static UniTask<bool> TimeoutWithoutException(this UniTask task, TimeSpan timeout, bool ignoreTimeScale = true, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, [Optional] CancellationTokenSource taskCancellationTokenSource)
		{
			return default(UniTask<bool>);
		}

		[AsyncStateMachine(typeof(<TimeoutWithoutException>d__16<>))]
		public static UniTask<ValueTuple<bool, T>> TimeoutWithoutException<T>(this UniTask<T> task, TimeSpan timeout, bool ignoreTimeScale = true, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, [Optional] CancellationTokenSource taskCancellationTokenSource)
		{
			return default(UniTask<ValueTuple<bool, T>>);
		}

		public static void Forget(this UniTask task)
		{
		}

		public static void Forget(this UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true)
		{
		}

		[AsyncStateMachine(typeof(<ForgetCore>d__19))]
		private static UniTaskVoid ForgetCore(UniTask task)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(<ForgetCoreWithCatch>d__20))]
		private static UniTaskVoid ForgetCoreWithCatch(UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread)
		{
			return default(UniTaskVoid);
		}

		public static void Forget<T>(this UniTask<T> task)
		{
		}

		public static void Forget<T>(this UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true)
		{
		}

		[AsyncStateMachine(typeof(<ForgetCore>d__23<>))]
		private static UniTaskVoid ForgetCore<T>(UniTask<T> task)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(<ForgetCoreWithCatch>d__24<>))]
		private static UniTaskVoid ForgetCoreWithCatch<T>(UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(<ContinueWith>d__25<>))]
		public static UniTask ContinueWith<T>(this UniTask<T> task, Action<T> continuationFunction)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<ContinueWith>d__26<>))]
		public static UniTask ContinueWith<T>(this UniTask<T> task, Func<T, UniTask> continuationFunction)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<ContinueWith>d__27<, >))]
		public static UniTask<TR> ContinueWith<TR, T>(this UniTask<T> task, Func<T, TR> continuationFunction)
		{
			return default(UniTask<TR>);
		}

		[AsyncStateMachine(typeof(<ContinueWith>d__28<, >))]
		public static UniTask<TR> ContinueWith<TR, T>(this UniTask<T> task, Func<T, UniTask<TR>> continuationFunction)
		{
			return default(UniTask<TR>);
		}

		[AsyncStateMachine(typeof(<ContinueWith>d__29))]
		public static UniTask ContinueWith(this UniTask task, Action continuationFunction)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<ContinueWith>d__30))]
		public static UniTask ContinueWith(this UniTask task, Func<UniTask> continuationFunction)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<ContinueWith>d__31<>))]
		public static UniTask<T> ContinueWith<T>(this UniTask task, Func<T> continuationFunction)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(<ContinueWith>d__32<>))]
		public static UniTask<T> ContinueWith<T>(this UniTask task, Func<UniTask<T>> continuationFunction)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(<ConfigureAwait>d__33))]
		public static UniTask ConfigureAwait(this Task task, PlayerLoopTiming timing)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<ConfigureAwait>d__34<>))]
		public static UniTask<T> ConfigureAwait<T>(this Task<T> task, PlayerLoopTiming timing)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(<ConfigureAwait>d__35))]
		public static UniTask ConfigureAwait(this UniTask task, PlayerLoopTiming timing)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<ConfigureAwait>d__36<>))]
		public static UniTask<T> ConfigureAwait<T>(this UniTask<T> task, PlayerLoopTiming timing)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(<Unwrap>d__37<>))]
		public static UniTask<T> Unwrap<T>(this UniTask<UniTask<T>> task)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(<Unwrap>d__38<>))]
		public static UniTask Unwrap<T>(this UniTask<UniTask> task)
		{
			return default(UniTask);
		}
	}
}
