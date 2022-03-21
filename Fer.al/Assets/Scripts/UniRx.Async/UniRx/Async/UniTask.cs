using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using UniRx.Async.CompilerServices;
using UniRx.Async.Internal;

namespace UniRx.Async
{
	[AsyncMethodBuilder(typeof(AsyncUniTaskMethodBuilder))]
	public struct UniTask : IEquatable<UniTask>
	{
		private class YieldPromise : PlayerLoopReusablePromiseBase
		{
			public YieldPromise(PlayerLoopTiming timing, CancellationToken cancellationToken)
			{
			}

			protected override void OnRunningStart()
			{
			}

			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		private class DelayFramePromise : PlayerLoopReusablePromiseBase<int>
		{
			private readonly int delayFrameCount;

			private int currentFrameCount;

			public DelayFramePromise(int delayFrameCount, PlayerLoopTiming timing, CancellationToken cancellationToken)
			{
			}

			protected override void OnRunningStart()
			{
			}

			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		private class DelayPromise : PlayerLoopReusablePromiseBase
		{
			private readonly float delayFrameTimeSpan;

			private float elapsed;

			public DelayPromise(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken)
			{
			}

			protected override void OnRunningStart()
			{
			}

			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		private class DelayIgnoreTimeScalePromise : PlayerLoopReusablePromiseBase
		{
			private readonly float delayFrameTimeSpan;

			private float elapsed;

			public DelayIgnoreTimeScalePromise(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken)
			{
			}

			protected override void OnRunningStart()
			{
			}

			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		private static class CanceledUniTaskCache<T>
		{
			public static readonly UniTask<T> Task;

			static CanceledUniTaskCache()
			{
			}
		}

		private class WaitUntilPromise : PlayerLoopReusablePromiseBase
		{
			private readonly Func<bool> predicate;

			public WaitUntilPromise(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken)
			{
			}

			protected override void OnRunningStart()
			{
			}

			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		private class WaitWhilePromise : PlayerLoopReusablePromiseBase
		{
			private readonly Func<bool> predicate;

			public WaitWhilePromise(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken)
			{
			}

			protected override void OnRunningStart()
			{
			}

			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		private class WaitUntilValueChangedUnityObjectPromise<T, U> : PlayerLoopReusablePromiseBase<U>
		{
			private readonly T target;

			private readonly Func<T, U> monitorFunction;

			private readonly IEqualityComparer<U> equalityComparer;

			private U currentValue;

			public WaitUntilValueChangedUnityObjectPromise(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken)
			{
			}

			protected override void OnRunningStart()
			{
			}

			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		private class WaitUntilValueChangedStandardObjectPromise<T, U> : PlayerLoopReusablePromiseBase<U> where T : class
		{
			private readonly WeakReference<T> target;

			private readonly Func<T, U> monitorFunction;

			private readonly IEqualityComparer<U> equalityComparer;

			private U currentValue;

			public WaitUntilValueChangedStandardObjectPromise(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken)
			{
			}

			protected override void OnRunningStart()
			{
			}

			public override bool MoveNext()
			{
				return default(bool);
			}
		}

		private class WhenAllPromise<T1, T2>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAllPromise<T1, T2> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAllPromise<T1, T2> parent)
				{
				}

				public ValueTuple<T1, T2> GetResult()
				{
					return default(ValueTuple<T1, T2>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask1Async>d__9 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAllPromise<T1, T2> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2Async>d__11 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAllPromise<T1, T2> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private const int MaxCount = 2;

			private T1 result1;

			private T2 result2;

			private ExceptionDispatchInfo exception;

			private int completeCount;

			private Action whenComplete;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2)
			{
			}

			private void TryCallContinuation()
			{
			}

			private void RunTask1(UniTask<T1> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, >.<RunTask1Async>d__9))]
			private UniTaskVoid RunTask1Async(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask2(UniTask<T2> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, >.<RunTask2Async>d__11))]
			private UniTaskVoid RunTask2Async(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAllPromise<T1, T2, T3>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAllPromise<T1, T2, T3> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAllPromise<T1, T2, T3> parent)
				{
				}

				public ValueTuple<T1, T2, T3> GetResult()
				{
					return default(ValueTuple<T1, T2, T3>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask1Async>d__10 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAllPromise<T1, T2, T3> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2Async>d__12 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAllPromise<T1, T2, T3> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

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
			private struct <RunTask3Async>d__14 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T3> task;

				public WhenAllPromise<T1, T2, T3> <>4__this;

				private UniTask<T3>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private const int MaxCount = 3;

			private T1 result1;

			private T2 result2;

			private T3 result3;

			private ExceptionDispatchInfo exception;

			private int completeCount;

			private Action whenComplete;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3)
			{
			}

			private void TryCallContinuation()
			{
			}

			private void RunTask1(UniTask<T1> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , >.<RunTask1Async>d__10))]
			private UniTaskVoid RunTask1Async(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask2(UniTask<T2> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , >.<RunTask2Async>d__12))]
			private UniTaskVoid RunTask2Async(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask3(UniTask<T3> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , >.<RunTask3Async>d__14))]
			private UniTaskVoid RunTask3Async(UniTask<T3> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAllPromise<T1, T2, T3, T4>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAllPromise<T1, T2, T3, T4> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAllPromise<T1, T2, T3, T4> parent)
				{
				}

				public ValueTuple<T1, T2, T3, T4> GetResult()
				{
					return default(ValueTuple<T1, T2, T3, T4>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask1Async>d__11 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAllPromise<T1, T2, T3, T4> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2Async>d__13 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAllPromise<T1, T2, T3, T4> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

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
			private struct <RunTask3Async>d__15 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T3> task;

				public WhenAllPromise<T1, T2, T3, T4> <>4__this;

				private UniTask<T3>.Awaiter <>u__1;

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
			private struct <RunTask4Async>d__17 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T4> task;

				public WhenAllPromise<T1, T2, T3, T4> <>4__this;

				private UniTask<T4>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private const int MaxCount = 4;

			private T1 result1;

			private T2 result2;

			private T3 result3;

			private T4 result4;

			private ExceptionDispatchInfo exception;

			private int completeCount;

			private Action whenComplete;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4)
			{
			}

			private void TryCallContinuation()
			{
			}

			private void RunTask1(UniTask<T1> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , >.<RunTask1Async>d__11))]
			private UniTaskVoid RunTask1Async(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask2(UniTask<T2> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , >.<RunTask2Async>d__13))]
			private UniTaskVoid RunTask2Async(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask3(UniTask<T3> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , >.<RunTask3Async>d__15))]
			private UniTaskVoid RunTask3Async(UniTask<T3> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask4(UniTask<T4> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , >.<RunTask4Async>d__17))]
			private UniTaskVoid RunTask4Async(UniTask<T4> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAllPromise<T1, T2, T3, T4, T5>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAllPromise<T1, T2, T3, T4, T5> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAllPromise<T1, T2, T3, T4, T5> parent)
				{
				}

				public ValueTuple<T1, T2, T3, T4, T5> GetResult()
				{
					return default(ValueTuple<T1, T2, T3, T4, T5>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask1Async>d__12 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2Async>d__14 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

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
			private struct <RunTask3Async>d__16 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T3> task;

				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;

				private UniTask<T3>.Awaiter <>u__1;

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
			private struct <RunTask4Async>d__18 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T4> task;

				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;

				private UniTask<T4>.Awaiter <>u__1;

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
			private struct <RunTask5Async>d__20 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T5> task;

				public WhenAllPromise<T1, T2, T3, T4, T5> <>4__this;

				private UniTask<T5>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private const int MaxCount = 5;

			private T1 result1;

			private T2 result2;

			private T3 result3;

			private T4 result4;

			private T5 result5;

			private ExceptionDispatchInfo exception;

			private int completeCount;

			private Action whenComplete;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5)
			{
			}

			private void TryCallContinuation()
			{
			}

			private void RunTask1(UniTask<T1> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , >.<RunTask1Async>d__12))]
			private UniTaskVoid RunTask1Async(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask2(UniTask<T2> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , >.<RunTask2Async>d__14))]
			private UniTaskVoid RunTask2Async(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask3(UniTask<T3> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , >.<RunTask3Async>d__16))]
			private UniTaskVoid RunTask3Async(UniTask<T3> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask4(UniTask<T4> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , >.<RunTask4Async>d__18))]
			private UniTaskVoid RunTask4Async(UniTask<T4> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask5(UniTask<T5> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , >.<RunTask5Async>d__20))]
			private UniTaskVoid RunTask5Async(UniTask<T5> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAllPromise<T1, T2, T3, T4, T5, T6>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAllPromise<T1, T2, T3, T4, T5, T6> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAllPromise<T1, T2, T3, T4, T5, T6> parent)
				{
				}

				public ValueTuple<T1, T2, T3, T4, T5, T6> GetResult()
				{
					return default(ValueTuple<T1, T2, T3, T4, T5, T6>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask1Async>d__13 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2Async>d__15 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

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
			private struct <RunTask3Async>d__17 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T3> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T3>.Awaiter <>u__1;

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
			private struct <RunTask4Async>d__19 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T4> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T4>.Awaiter <>u__1;

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
			private struct <RunTask5Async>d__21 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T5> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T5>.Awaiter <>u__1;

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
			private struct <RunTask6Async>d__23 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T6> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T6>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private const int MaxCount = 6;

			private T1 result1;

			private T2 result2;

			private T3 result3;

			private T4 result4;

			private T5 result5;

			private T6 result6;

			private ExceptionDispatchInfo exception;

			private int completeCount;

			private Action whenComplete;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6)
			{
			}

			private void TryCallContinuation()
			{
			}

			private void RunTask1(UniTask<T1> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , >.<RunTask1Async>d__13))]
			private UniTaskVoid RunTask1Async(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask2(UniTask<T2> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , >.<RunTask2Async>d__15))]
			private UniTaskVoid RunTask2Async(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask3(UniTask<T3> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , >.<RunTask3Async>d__17))]
			private UniTaskVoid RunTask3Async(UniTask<T3> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask4(UniTask<T4> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , >.<RunTask4Async>d__19))]
			private UniTaskVoid RunTask4Async(UniTask<T4> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask5(UniTask<T5> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , >.<RunTask5Async>d__21))]
			private UniTaskVoid RunTask5Async(UniTask<T5> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask6(UniTask<T6> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , >.<RunTask6Async>d__23))]
			private UniTaskVoid RunTask6Async(UniTask<T6> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> parent)
				{
				}

				public ValueTuple<T1, T2, T3, T4, T5, T6, T7> GetResult()
				{
					return default(ValueTuple<T1, T2, T3, T4, T5, T6, T7>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask1Async>d__14 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2Async>d__16 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

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
			private struct <RunTask3Async>d__18 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T3> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T3>.Awaiter <>u__1;

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
			private struct <RunTask4Async>d__20 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T4> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T4>.Awaiter <>u__1;

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
			private struct <RunTask5Async>d__22 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T5> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T5>.Awaiter <>u__1;

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
			private struct <RunTask6Async>d__24 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T6> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T6>.Awaiter <>u__1;

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
			private struct <RunTask7Async>d__26 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T7> task;

				public WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T7>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private const int MaxCount = 7;

			private T1 result1;

			private T2 result2;

			private T3 result3;

			private T4 result4;

			private T5 result5;

			private T6 result6;

			private T7 result7;

			private ExceptionDispatchInfo exception;

			private int completeCount;

			private Action whenComplete;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7)
			{
			}

			private void TryCallContinuation()
			{
			}

			private void RunTask1(UniTask<T1> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , , >.<RunTask1Async>d__14))]
			private UniTaskVoid RunTask1Async(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask2(UniTask<T2> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , , >.<RunTask2Async>d__16))]
			private UniTaskVoid RunTask2Async(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask3(UniTask<T3> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , , >.<RunTask3Async>d__18))]
			private UniTaskVoid RunTask3Async(UniTask<T3> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask4(UniTask<T4> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , , >.<RunTask4Async>d__20))]
			private UniTaskVoid RunTask4Async(UniTask<T4> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask5(UniTask<T5> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , , >.<RunTask5Async>d__22))]
			private UniTaskVoid RunTask5Async(UniTask<T5> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask6(UniTask<T6> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , , >.<RunTask6Async>d__24))]
			private UniTaskVoid RunTask6Async(UniTask<T6> task)
			{
				return default(UniTaskVoid);
			}

			private void RunTask7(UniTask<T7> task)
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<, , , , , , >.<RunTask7Async>d__26))]
			private UniTaskVoid RunTask7Async(UniTask<T7> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAllPromise<T>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAllPromise<T> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAllPromise<T> parent)
				{
				}

				public T[] GetResult()
				{
					return null;
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask>d__6 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T> task;

				public WhenAllPromise<T> <>4__this;

				public int index;

				private UniTask<T>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private readonly T[] result;

			private int completeCount;

			private Action whenComplete;

			private ExceptionDispatchInfo exception;

			public WhenAllPromise(UniTask<T>[] tasks, int tasksLength)
			{
			}

			private void TryCallContinuation()
			{
			}

			[AsyncStateMachine(typeof(WhenAllPromise<>.<RunTask>d__6))]
			private UniTaskVoid RunTask(UniTask<T> task, int index)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAllPromise
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAllPromise parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAllPromise parent)
				{
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

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask>d__6 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask task;

				public WhenAllPromise <>4__this;

				private UniTask.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private int completeCount;

			private int resultLength;

			private Action whenComplete;

			private ExceptionDispatchInfo exception;

			public WhenAllPromise(UniTask[] tasks, int tasksLength)
			{
			}

			private void TryCallContinuation()
			{
			}

			[AsyncStateMachine(typeof(<RunTask>d__6))]
			private UniTaskVoid RunTask(UniTask task, int index)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAnyPromise<T0, T1>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAnyPromise<T0, T1> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAnyPromise<T0, T1> parent)
				{
				}

				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>> GetResult()
				{
					return default(ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask0>d__10 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T0> task;

				public WhenAnyPromise<T0, T1> <>4__this;

				private UniTask<T0>.Awaiter <>u__1;

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
			private struct <RunTask1>d__11 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAnyPromise<T0, T1> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private T0 result0;

			private T1 result1;

			private ExceptionDispatchInfo exception;

			private Action whenComplete;

			private int completeCount;

			private int winArgumentIndex;

			private bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1)
			{
			}

			private void TryCallContinuation()
			{
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, >.<RunTask0>d__10))]
			private UniTaskVoid RunTask0(UniTask<T0> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, >.<RunTask1>d__11))]
			private UniTaskVoid RunTask1(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAnyPromise<T0, T1, T2>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAnyPromise<T0, T1, T2> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAnyPromise<T0, T1, T2> parent)
				{
				}

				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>> GetResult()
				{
					return default(ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask0>d__11 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T0> task;

				public WhenAnyPromise<T0, T1, T2> <>4__this;

				private UniTask<T0>.Awaiter <>u__1;

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
			private struct <RunTask1>d__12 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAnyPromise<T0, T1, T2> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2>d__13 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAnyPromise<T0, T1, T2> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private T0 result0;

			private T1 result1;

			private T2 result2;

			private ExceptionDispatchInfo exception;

			private Action whenComplete;

			private int completeCount;

			private int winArgumentIndex;

			private bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2)
			{
			}

			private void TryCallContinuation()
			{
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , >.<RunTask0>d__11))]
			private UniTaskVoid RunTask0(UniTask<T0> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , >.<RunTask1>d__12))]
			private UniTaskVoid RunTask1(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , >.<RunTask2>d__13))]
			private UniTaskVoid RunTask2(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAnyPromise<T0, T1, T2, T3>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAnyPromise<T0, T1, T2, T3> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAnyPromise<T0, T1, T2, T3> parent)
				{
				}

				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>> GetResult()
				{
					return default(ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask0>d__12 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T0> task;

				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;

				private UniTask<T0>.Awaiter <>u__1;

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
			private struct <RunTask1>d__13 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2>d__14 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

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
			private struct <RunTask3>d__15 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T3> task;

				public WhenAnyPromise<T0, T1, T2, T3> <>4__this;

				private UniTask<T3>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private T0 result0;

			private T1 result1;

			private T2 result2;

			private T3 result3;

			private ExceptionDispatchInfo exception;

			private Action whenComplete;

			private int completeCount;

			private int winArgumentIndex;

			private bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3)
			{
			}

			private void TryCallContinuation()
			{
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , >.<RunTask0>d__12))]
			private UniTaskVoid RunTask0(UniTask<T0> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , >.<RunTask1>d__13))]
			private UniTaskVoid RunTask1(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , >.<RunTask2>d__14))]
			private UniTaskVoid RunTask2(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , >.<RunTask3>d__15))]
			private UniTaskVoid RunTask3(UniTask<T3> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAnyPromise<T0, T1, T2, T3, T4>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAnyPromise<T0, T1, T2, T3, T4> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4> parent)
				{
				}

				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>> GetResult()
				{
					return default(ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask0>d__13 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T0> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;

				private UniTask<T0>.Awaiter <>u__1;

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
			private struct <RunTask1>d__14 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2>d__15 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

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
			private struct <RunTask3>d__16 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T3> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;

				private UniTask<T3>.Awaiter <>u__1;

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
			private struct <RunTask4>d__17 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T4> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this;

				private UniTask<T4>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private T0 result0;

			private T1 result1;

			private T2 result2;

			private T3 result3;

			private T4 result4;

			private ExceptionDispatchInfo exception;

			private Action whenComplete;

			private int completeCount;

			private int winArgumentIndex;

			private bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4)
			{
			}

			private void TryCallContinuation()
			{
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , >.<RunTask0>d__13))]
			private UniTaskVoid RunTask0(UniTask<T0> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , >.<RunTask1>d__14))]
			private UniTaskVoid RunTask1(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , >.<RunTask2>d__15))]
			private UniTaskVoid RunTask2(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , >.<RunTask3>d__16))]
			private UniTaskVoid RunTask3(UniTask<T3> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , >.<RunTask4>d__17))]
			private UniTaskVoid RunTask4(UniTask<T4> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAnyPromise<T0, T1, T2, T3, T4, T5> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4, T5> parent)
				{
				}

				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>> GetResult()
				{
					return default(ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask0>d__14 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T0> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;

				private UniTask<T0>.Awaiter <>u__1;

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
			private struct <RunTask1>d__15 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2>d__16 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

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
			private struct <RunTask3>d__17 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T3> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;

				private UniTask<T3>.Awaiter <>u__1;

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
			private struct <RunTask4>d__18 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T4> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;

				private UniTask<T4>.Awaiter <>u__1;

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
			private struct <RunTask5>d__19 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T5> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this;

				private UniTask<T5>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private T0 result0;

			private T1 result1;

			private T2 result2;

			private T3 result3;

			private T4 result4;

			private T5 result5;

			private ExceptionDispatchInfo exception;

			private Action whenComplete;

			private int completeCount;

			private int winArgumentIndex;

			private bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5)
			{
			}

			private void TryCallContinuation()
			{
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , >.<RunTask0>d__14))]
			private UniTaskVoid RunTask0(UniTask<T0> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , >.<RunTask1>d__15))]
			private UniTaskVoid RunTask1(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , >.<RunTask2>d__16))]
			private UniTaskVoid RunTask2(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , >.<RunTask3>d__17))]
			private UniTaskVoid RunTask3(UniTask<T3> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , >.<RunTask4>d__18))]
			private UniTaskVoid RunTask4(UniTask<T4> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , >.<RunTask5>d__19))]
			private UniTaskVoid RunTask5(UniTask<T5> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> parent)
				{
				}

				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>> GetResult()
				{
					return default(ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask0>d__15 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T0> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T0>.Awaiter <>u__1;

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
			private struct <RunTask1>d__16 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2>d__17 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

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
			private struct <RunTask3>d__18 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T3> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T3>.Awaiter <>u__1;

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
			private struct <RunTask4>d__19 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T4> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T4>.Awaiter <>u__1;

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
			private struct <RunTask5>d__20 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T5> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T5>.Awaiter <>u__1;

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
			private struct <RunTask6>d__21 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T6> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this;

				private UniTask<T6>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private T0 result0;

			private T1 result1;

			private T2 result2;

			private T3 result3;

			private T4 result4;

			private T5 result5;

			private T6 result6;

			private ExceptionDispatchInfo exception;

			private Action whenComplete;

			private int completeCount;

			private int winArgumentIndex;

			private bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6)
			{
			}

			private void TryCallContinuation()
			{
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , >.<RunTask0>d__15))]
			private UniTaskVoid RunTask0(UniTask<T0> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , >.<RunTask1>d__16))]
			private UniTaskVoid RunTask1(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , >.<RunTask2>d__17))]
			private UniTaskVoid RunTask2(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , >.<RunTask3>d__18))]
			private UniTaskVoid RunTask3(UniTask<T3> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , >.<RunTask4>d__19))]
			private UniTaskVoid RunTask4(UniTask<T4> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , >.<RunTask5>d__20))]
			private UniTaskVoid RunTask5(UniTask<T5> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , >.<RunTask6>d__21))]
			private UniTaskVoid RunTask6(UniTask<T6> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> parent)
				{
				}

				public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>> GetResult()
				{
					return default(ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask0>d__16 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T0> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T0>.Awaiter <>u__1;

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
			private struct <RunTask1>d__17 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T1> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T1>.Awaiter <>u__1;

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
			private struct <RunTask2>d__18 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T2> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T2>.Awaiter <>u__1;

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
			private struct <RunTask3>d__19 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T3> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T3>.Awaiter <>u__1;

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
			private struct <RunTask4>d__20 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T4> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T4>.Awaiter <>u__1;

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
			private struct <RunTask5>d__21 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T5> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T5>.Awaiter <>u__1;

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
			private struct <RunTask6>d__22 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T6> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T6>.Awaiter <>u__1;

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
			private struct <RunTask7>d__23 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T7> task;

				public WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this;

				private UniTask<T7>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private T0 result0;

			private T1 result1;

			private T2 result2;

			private T3 result3;

			private T4 result4;

			private T5 result5;

			private T6 result6;

			private T7 result7;

			private ExceptionDispatchInfo exception;

			private Action whenComplete;

			private int completeCount;

			private int winArgumentIndex;

			private bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public WhenAnyPromise(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7)
			{
			}

			private void TryCallContinuation()
			{
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , , >.<RunTask0>d__16))]
			private UniTaskVoid RunTask0(UniTask<T0> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , , >.<RunTask1>d__17))]
			private UniTaskVoid RunTask1(UniTask<T1> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , , >.<RunTask2>d__18))]
			private UniTaskVoid RunTask2(UniTask<T2> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , , >.<RunTask3>d__19))]
			private UniTaskVoid RunTask3(UniTask<T3> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , , >.<RunTask4>d__20))]
			private UniTaskVoid RunTask4(UniTask<T4> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , , >.<RunTask5>d__21))]
			private UniTaskVoid RunTask5(UniTask<T5> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , , >.<RunTask6>d__22))]
			private UniTaskVoid RunTask6(UniTask<T6> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<, , , , , , , >.<RunTask7>d__23))]
			private UniTaskVoid RunTask7(UniTask<T7> task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class UnitWhenAnyPromise<T0>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private UnitWhenAnyPromise<T0> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(UnitWhenAnyPromise<T0> parent)
				{
				}

				public ValueTuple<bool, T0> GetResult()
				{
					return default(ValueTuple<bool, T0>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask0>d__9 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T0> task;

				public UnitWhenAnyPromise<T0> <>4__this;

				private UniTask<T0>.Awaiter <>u__1;

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
			private struct <RunTask1>d__10 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask task;

				public UnitWhenAnyPromise<T0> <>4__this;

				private UniTask.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private T0 result0;

			private ExceptionDispatchInfo exception;

			private Action whenComplete;

			private int completeCount;

			private int winArgumentIndex;

			private bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public UnitWhenAnyPromise(UniTask<T0> task0, UniTask task1)
			{
			}

			private void TryCallContinuation()
			{
			}

			[AsyncStateMachine(typeof(UnitWhenAnyPromise<>.<RunTask0>d__9))]
			private UniTaskVoid RunTask0(UniTask<T0> task)
			{
				return default(UniTaskVoid);
			}

			[AsyncStateMachine(typeof(UnitWhenAnyPromise<>.<RunTask1>d__10))]
			private UniTaskVoid RunTask1(UniTask task)
			{
				return default(UniTaskVoid);
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAnyPromise<T>
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAnyPromise<T> parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAnyPromise<T> parent)
				{
				}

				public ValueTuple<int, T> GetResult()
				{
					return default(ValueTuple<int, T>);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask>d__8 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask<T> task;

				public WhenAnyPromise<T> <>4__this;

				public int index;

				private UniTask<T>.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private T result;

			private int completeCount;

			private int winArgumentIndex;

			private Action whenComplete;

			private ExceptionDispatchInfo exception;

			public bool IsComplete
			{
				get
				{
					return default(bool);
				}
			}

			public WhenAnyPromise(UniTask<T>[] tasks)
			{
			}

			[AsyncStateMachine(typeof(WhenAnyPromise<>.<RunTask>d__8))]
			private UniTaskVoid RunTask(UniTask<T> task, int index)
			{
				return default(UniTaskVoid);
			}

			private void TryCallContinuation()
			{
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class WhenAnyPromise
		{
			public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
			{
				private WhenAnyPromise parent;

				public bool IsCompleted
				{
					get
					{
						return default(bool);
					}
				}

				public Awaiter(WhenAnyPromise parent)
				{
				}

				public int GetResult()
				{
					return default(int);
				}

				public void OnCompleted(Action continuation)
				{
				}

				public void UnsafeOnCompleted(Action continuation)
				{
				}
			}

			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct <RunTask>d__7 : IAsyncStateMachine
			{
				public int <>1__state;

				public AsyncUniTaskVoidMethodBuilder <>t__builder;

				public UniTask task;

				public WhenAnyPromise <>4__this;

				public int index;

				private UniTask.Awaiter <>u__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			private int completeCount;

			private int winArgumentIndex;

			private Action whenComplete;

			private ExceptionDispatchInfo exception;

			public bool IsComplete
			{
				get
				{
					return default(bool);
				}
			}

			public WhenAnyPromise(UniTask[] tasks)
			{
			}

			[AsyncStateMachine(typeof(<RunTask>d__7))]
			private UniTaskVoid RunTask(UniTask task, int index)
			{
				return default(UniTaskVoid);
			}

			private void TryCallContinuation()
			{
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}
		}

		private class AsyncUnitAwaiter : IAwaiter<AsyncUnit>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly IAwaiter awaiter;

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

			public AsyncUnitAwaiter(IAwaiter awaiter)
			{
			}

			public AsyncUnit GetResult()
			{
				return default(AsyncUnit);
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

		private class IsCanceledAwaiter : IAwaiter<bool>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly IAwaiter awaiter;

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

			public IsCanceledAwaiter(IAwaiter awaiter)
			{
			}

			public bool GetResult()
			{
				return default(bool);
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

		public struct Awaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly UniTask task;

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
			public Awaiter(UniTask task)
			{
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

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <Run>d__24 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public bool configureAwait;

			public Action action;

			private SwitchToThreadPoolAwaitable.Awaiter <>u__1;

			private object <>7__wrap1;

			private int <>7__wrap2;

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
		private struct <Run>d__25 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public bool configureAwait;

			public Action<object> action;

			public object state;

			private SwitchToThreadPoolAwaitable.Awaiter <>u__1;

			private object <>7__wrap1;

			private int <>7__wrap2;

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
		private struct <Run>d__26<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<T> <>t__builder;

			public bool configureAwait;

			public Func<T> func;

			private SwitchToThreadPoolAwaitable.Awaiter <>u__1;

			private object <>7__wrap1;

			private int <>7__wrap2;

			private T <>7__wrap3;

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
		private struct <Run>d__27<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<T> <>t__builder;

			public bool configureAwait;

			public Func<object, T> func;

			public object state;

			private SwitchToThreadPoolAwaitable.Awaiter <>u__1;

			private object <>7__wrap1;

			private int <>7__wrap2;

			private T <>7__wrap3;

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
		private struct <WhenAll>d__39<T1, T2> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2>> <>t__builder;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			private WhenAllPromise<T1, T2>.Awaiter <>u__1;

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
		private struct <WhenAll>d__40<T1, T2, T3> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3>> <>t__builder;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			public UniTask<T3> task3;

			private WhenAllPromise<T1, T2, T3>.Awaiter <>u__1;

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
		private struct <WhenAll>d__41<T1, T2, T3, T4> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4>> <>t__builder;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			public UniTask<T3> task3;

			public UniTask<T4> task4;

			private WhenAllPromise<T1, T2, T3, T4>.Awaiter <>u__1;

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
		private struct <WhenAll>d__42<T1, T2, T3, T4, T5> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5>> <>t__builder;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			public UniTask<T3> task3;

			public UniTask<T4> task4;

			public UniTask<T5> task5;

			private WhenAllPromise<T1, T2, T3, T4, T5>.Awaiter <>u__1;

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
		private struct <WhenAll>d__43<T1, T2, T3, T4, T5, T6> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5, T6>> <>t__builder;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			public UniTask<T3> task3;

			public UniTask<T4> task4;

			public UniTask<T5> task5;

			public UniTask<T6> task6;

			private WhenAllPromise<T1, T2, T3, T4, T5, T6>.Awaiter <>u__1;

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
		private struct <WhenAll>d__44<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> <>t__builder;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			public UniTask<T3> task3;

			public UniTask<T4> task4;

			public UniTask<T5> task5;

			public UniTask<T6> task6;

			public UniTask<T7> task7;

			private WhenAllPromise<T1, T2, T3, T4, T5, T6, T7>.Awaiter <>u__1;

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
		private struct <WhenAll>d__51<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<T[]> <>t__builder;

			public UniTask<T>[] tasks;

			private WhenAllPromise<T>.Awaiter <>u__1;

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
		private struct <WhenAll>d__52<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<T[]> <>t__builder;

			public IEnumerable<UniTask<T>> tasks;

			private WhenAllPromise<T>.Awaiter <>u__1;

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
		private struct <WhenAll>d__53 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public UniTask[] tasks;

			private WhenAllPromise.Awaiter <>u__1;

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
		private struct <WhenAll>d__54 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public IEnumerable<UniTask> tasks;

			private WhenAllPromise.Awaiter <>u__1;

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
		private struct <WhenAny>d__57<T0, T1> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>> <>t__builder;

			public UniTask<T0> task0;

			public UniTask<T1> task1;

			private WhenAnyPromise<T0, T1>.Awaiter <>u__1;

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
		private struct <WhenAny>d__58<T0, T1, T2> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>> <>t__builder;

			public UniTask<T0> task0;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			private WhenAnyPromise<T0, T1, T2>.Awaiter <>u__1;

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
		private struct <WhenAny>d__59<T0, T1, T2, T3> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>> <>t__builder;

			public UniTask<T0> task0;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			public UniTask<T3> task3;

			private WhenAnyPromise<T0, T1, T2, T3>.Awaiter <>u__1;

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
		private struct <WhenAny>d__60<T0, T1, T2, T3, T4> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>> <>t__builder;

			public UniTask<T0> task0;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			public UniTask<T3> task3;

			public UniTask<T4> task4;

			private WhenAnyPromise<T0, T1, T2, T3, T4>.Awaiter <>u__1;

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
		private struct <WhenAny>d__61<T0, T1, T2, T3, T4, T5> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>>> <>t__builder;

			public UniTask<T0> task0;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			public UniTask<T3> task3;

			public UniTask<T4> task4;

			public UniTask<T5> task5;

			private WhenAnyPromise<T0, T1, T2, T3, T4, T5>.Awaiter <>u__1;

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
		private struct <WhenAny>d__62<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>>> <>t__builder;

			public UniTask<T0> task0;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			public UniTask<T3> task3;

			public UniTask<T4> task4;

			public UniTask<T5> task5;

			public UniTask<T6> task6;

			private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6>.Awaiter <>u__1;

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
		private struct <WhenAny>d__63<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>>> <>t__builder;

			public UniTask<T0> task0;

			public UniTask<T1> task1;

			public UniTask<T2> task2;

			public UniTask<T3> task3;

			public UniTask<T4> task4;

			public UniTask<T5> task5;

			public UniTask<T6> task6;

			public UniTask<T7> task7;

			private WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7>.Awaiter <>u__1;

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
		private struct <WhenAny>d__71<T0> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<bool, T0>> <>t__builder;

			public UniTask<T0> task0;

			public UniTask task1;

			private UnitWhenAnyPromise<T0>.Awaiter <>u__1;

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
		private struct <WhenAny>d__72<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ValueTuple<int, T>> <>t__builder;

			public UniTask<T>[] tasks;

			private WhenAnyPromise<T>.Awaiter <>u__1;

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
		private struct <WhenAny>d__73 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<int> <>t__builder;

			public UniTask[] tasks;

			private WhenAnyPromise.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static readonly UniTask CanceledUniTask;

		private static readonly UniTask<AsyncUnit> DefaultAsyncUnitTask;

		private readonly IAwaiter awaiter;

		public static UniTask CompletedTask
		{
			get
			{
				return default(UniTask);
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
		public bool IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		public static IEnumerator ToCoroutine(Func<UniTask> taskFactory)
		{
			return null;
		}

		public static YieldAwaitable Yield(PlayerLoopTiming timing = PlayerLoopTiming.Update)
		{
			return default(YieldAwaitable);
		}

		public static UniTask Yield(PlayerLoopTiming timing, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask<int> DelayFrame(int delayFrameCount, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		public static UniTask Delay(int millisecondsDelay, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask Delay(TimeSpan delayTimeSpan, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask FromException(Exception ex)
		{
			return default(UniTask);
		}

		public static UniTask<T> FromException<T>(Exception ex)
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> FromResult<T>(T value)
		{
			return default(UniTask<T>);
		}

		public static UniTask FromCanceled()
		{
			return default(UniTask);
		}

		public static UniTask<T> FromCanceled<T>()
		{
			return default(UniTask<T>);
		}

		public static UniTask FromCanceled(CancellationToken token)
		{
			return default(UniTask);
		}

		public static UniTask<T> FromCanceled<T>(CancellationToken token)
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> Lazy<T>(Func<UniTask<T>> factory)
		{
			return default(UniTask<T>);
		}

		public static void Void(Func<UniTask> asyncAction)
		{
		}

		public static void Void<T>(Func<T, UniTask> asyncAction, T state)
		{
		}

		[AsyncStateMachine(typeof(<Run>d__24))]
		public static UniTask Run(Action action, bool configureAwait = true)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<Run>d__25))]
		public static UniTask Run(Action<object> action, object state, bool configureAwait = true)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<Run>d__26<>))]
		public static UniTask<T> Run<T>(Func<T> func, bool configureAwait = true)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(<Run>d__27<>))]
		public static UniTask<T> Run<T>(Func<object, T> func, object state, bool configureAwait = true)
		{
			return default(UniTask<T>);
		}

		public static SwitchToMainThreadAwaitable SwitchToMainThread()
		{
			return default(SwitchToMainThreadAwaitable);
		}

		public static SwitchToThreadPoolAwaitable SwitchToThreadPool()
		{
			return default(SwitchToThreadPoolAwaitable);
		}

		public static SwitchToTaskPoolAwaitable SwitchToTaskPool()
		{
			return default(SwitchToTaskPoolAwaitable);
		}

		public static SwitchToSynchronizationContextAwaitable SwitchToSynchronizationContext(SynchronizationContext syncContext)
		{
			return default(SwitchToSynchronizationContextAwaitable);
		}

		public static UniTask WaitUntil(Func<bool> predicate, PlayerLoopTiming timing = PlayerLoopTiming.Update, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask WaitWhile(Func<bool> predicate, PlayerLoopTiming timing = PlayerLoopTiming.Update, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask<U> WaitUntilValueChanged<U, T>(T target, Func<T, U> monitorFunction, PlayerLoopTiming monitorTiming = PlayerLoopTiming.Update, [Optional] IEqualityComparer<U> equalityComparer, [Optional] CancellationToken cancellationToken) where T : class
		{
			return default(UniTask<U>);
		}

		[AsyncStateMachine(typeof(<WhenAll>d__39<, >))]
		public static UniTask<ValueTuple<T1, T2>> WhenAll<T1, T2>(UniTask<T1> task1, UniTask<T2> task2)
		{
			return default(UniTask<ValueTuple<T1, T2>>);
		}

		[AsyncStateMachine(typeof(<WhenAll>d__40<, , >))]
		public static UniTask<ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3)
		{
			return default(UniTask<ValueTuple<T1, T2, T3>>);
		}

		[AsyncStateMachine(typeof(<WhenAll>d__41<, , , >))]
		public static UniTask<ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4)
		{
			return default(UniTask<ValueTuple<T1, T2, T3, T4>>);
		}

		[AsyncStateMachine(typeof(<WhenAll>d__42<, , , , >))]
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5)
		{
			return default(UniTask<ValueTuple<T1, T2, T3, T4, T5>>);
		}

		[AsyncStateMachine(typeof(<WhenAll>d__43<, , , , , >))]
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6)
		{
			return default(UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>>);
		}

		[AsyncStateMachine(typeof(<WhenAll>d__44<, , , , , , >))]
		public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7)
		{
			return default(UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>);
		}

		[AsyncStateMachine(typeof(<WhenAll>d__51<>))]
		public static UniTask<T[]> WhenAll<T>(UniTask<T>[] tasks)
		{
			return default(UniTask<T[]>);
		}

		[AsyncStateMachine(typeof(<WhenAll>d__52<>))]
		public static UniTask<T[]> WhenAll<T>(IEnumerable<UniTask<T>> tasks)
		{
			return default(UniTask<T[]>);
		}

		[AsyncStateMachine(typeof(<WhenAll>d__53))]
		public static UniTask WhenAll(UniTask[] tasks)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<WhenAll>d__54))]
		public static UniTask WhenAll(IEnumerable<UniTask> tasks)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<WhenAny>d__57<, >))]
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>> WhenAny<T0, T1>(UniTask<T0> task0, UniTask<T1> task1)
		{
			return default(UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>>);
		}

		[AsyncStateMachine(typeof(<WhenAny>d__58<, , >))]
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>> WhenAny<T0, T1, T2>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2)
		{
			return default(UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>>);
		}

		[AsyncStateMachine(typeof(<WhenAny>d__59<, , , >))]
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>> WhenAny<T0, T1, T2, T3>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3)
		{
			return default(UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>>);
		}

		[AsyncStateMachine(typeof(<WhenAny>d__60<, , , , >))]
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>> WhenAny<T0, T1, T2, T3, T4>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4)
		{
			return default(UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>>);
		}

		[AsyncStateMachine(typeof(<WhenAny>d__61<, , , , , >))]
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>>> WhenAny<T0, T1, T2, T3, T4, T5>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5)
		{
			return default(UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>>>);
		}

		[AsyncStateMachine(typeof(<WhenAny>d__62<, , , , , , >))]
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>>> WhenAny<T0, T1, T2, T3, T4, T5, T6>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6)
		{
			return default(UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>>>);
		}

		[AsyncStateMachine(typeof(<WhenAny>d__63<, , , , , , , >))]
		public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>>> WhenAny<T0, T1, T2, T3, T4, T5, T6, T7>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7)
		{
			return default(UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>>>);
		}

		[AsyncStateMachine(typeof(<WhenAny>d__71<>))]
		public static UniTask<ValueTuple<bool, T0>> WhenAny<T0>(UniTask<T0> task0, UniTask task1)
		{
			return default(UniTask<ValueTuple<bool, T0>>);
		}

		[AsyncStateMachine(typeof(<WhenAny>d__72<>))]
		public static UniTask<ValueTuple<int, T>> WhenAny<T>(UniTask<T>[] tasks)
		{
			return default(UniTask<ValueTuple<int, T>>);
		}

		[AsyncStateMachine(typeof(<WhenAny>d__73))]
		public static UniTask<int> WhenAny(UniTask[] tasks)
		{
			return default(UniTask<int>);
		}

		[DebuggerHidden]
		public UniTask(IAwaiter awaiter)
		{
		}

		[DebuggerHidden]
		public UniTask(Func<UniTask> factory)
		{
		}

		[DebuggerHidden]
		public void GetResult()
		{
		}

		[DebuggerHidden]
		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}

		public UniTask<bool> SuppressCancellationThrow()
		{
			return default(UniTask<bool>);
		}

		public bool Equals(UniTask other)
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

		public static implicit operator UniTask<AsyncUnit>(UniTask task)
		{
			return default(UniTask<AsyncUnit>);
		}
	}
}
