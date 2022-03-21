using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using UniRx.Async.CompilerServices;
using UniRx.Async.Internal;

namespace UniRx.Async
{
	public static class UniTaskObservableExtensions
	{
		private class ToUniTaskObserver<T> : IObserver<T>
		{
			private static readonly Action<object> callback;

			private readonly UniTaskCompletionSource<T> promise;

			private readonly SingleAssignmentDisposable disposable;

			private readonly CancellationToken cancellationToken;

			private readonly CancellationTokenRegistration registration;

			private bool hasValue;

			private T latestValue;

			public ToUniTaskObserver(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken)
			{
			}

			private static void OnCanceled(object state)
			{
			}

			public void OnNext(T value)
			{
			}

			public void OnError(Exception error)
			{
			}

			public void OnCompleted()
			{
			}
		}

		private class FirstValueToUniTaskObserver<T> : IObserver<T>
		{
			private static readonly Action<object> callback;

			private readonly UniTaskCompletionSource<T> promise;

			private readonly SingleAssignmentDisposable disposable;

			private readonly CancellationToken cancellationToken;

			private readonly CancellationTokenRegistration registration;

			private bool hasValue;

			public FirstValueToUniTaskObserver(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken)
			{
			}

			private static void OnCanceled(object state)
			{
			}

			public void OnNext(T value)
			{
			}

			public void OnError(Exception error)
			{
			}

			public void OnCompleted()
			{
			}
		}

		private class ReturnObservable<T> : IObservable<T>
		{
			private readonly T value;

			public ReturnObservable(T value)
			{
			}

			public IDisposable Subscribe(IObserver<T> observer)
			{
				return null;
			}
		}

		private class ThrowObservable<T> : IObservable<T>
		{
			private readonly Exception value;

			public ThrowObservable(Exception value)
			{
			}

			public IDisposable Subscribe(IObserver<T> observer)
			{
				return null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <Fire>d__3<T> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			public UniTask<T> task;

			public AsyncSubject<T> subject;

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
		private struct <Fire>d__4 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskVoidMethodBuilder <>t__builder;

			public UniTask task;

			public AsyncSubject<object> subject;

			private UniTask.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public static UniTask<T> ToUniTask<T>(this IObservable<T> source, [Optional] CancellationToken cancellationToken, bool useFirstValue = false)
		{
			return default(UniTask<T>);
		}

		public static IObservable<T> ToObservable<T>(this UniTask<T> task)
		{
			return null;
		}

		public static IObservable<AsyncUnit> ToObservable(this UniTask task)
		{
			return null;
		}

		[AsyncStateMachine(typeof(<Fire>d__3<>))]
		private static UniTaskVoid Fire<T>(AsyncSubject<T> subject, UniTask<T> task)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(<Fire>d__4))]
		private static UniTaskVoid Fire(AsyncSubject<object> subject, UniTask task)
		{
			return default(UniTaskVoid);
		}
	}
}
