using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

namespace UniRx.Async.CompilerServices
{
	public struct AsyncUniTaskMethodBuilder
	{
		private UniTaskCompletionSource promise;

		private Action moveNext;

		[DebuggerHidden]
		public UniTask Task
		{
			get
			{
				return default(UniTask);
			}
		}

		[DebuggerHidden]
		public static AsyncUniTaskMethodBuilder Create()
		{
			return default(AsyncUniTaskMethodBuilder);
		}

		[DebuggerHidden]
		public void SetException(Exception exception)
		{
		}

		[DebuggerHidden]
		public void SetResult()
		{
		}

		[DebuggerHidden]
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		[DebuggerHidden]
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		[DebuggerHidden]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
		}

		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}
}
