using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async
{
	public static class EnumeratorAsyncExtensions
	{
		private class EnumeratorAwaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem
		{
			private IEnumerator innerEnumerator;

			private CancellationToken cancellationToken;

			private Action continuation;

			private AwaiterStatus status;

			private ExceptionDispatchInfo exception;

			private static readonly FieldInfo waitForSeconds_Seconds;

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

			public EnumeratorAwaiter(IEnumerator innerEnumerator, CancellationToken cancellationToken)
			{
			}

			public void GetResult()
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			private void InvokeContinuation(AwaiterStatus status)
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}

			[IteratorStateMachine(typeof(<ConsumeEnumerator>d__15))]
			private static IEnumerator ConsumeEnumerator(IEnumerator enumerator)
			{
				return null;
			}

			[IteratorStateMachine(typeof(<UnwrapWaitCustomYieldInstruction>d__16))]
			private static IEnumerator UnwrapWaitCustomYieldInstruction(CustomYieldInstruction yieldInstruction)
			{
				return null;
			}

			[IteratorStateMachine(typeof(<UnwrapWaitForSeconds>d__18))]
			private static IEnumerator UnwrapWaitForSeconds(WaitForSeconds waitForSeconds)
			{
				return null;
			}

			[IteratorStateMachine(typeof(<UnwrapWaitAsyncOperation>d__19))]
			private static IEnumerator UnwrapWaitAsyncOperation(AsyncOperation asyncOperation)
			{
				return null;
			}
		}

		public static IAwaiter GetAwaiter(this IEnumerator enumerator)
		{
			return null;
		}

		public static UniTask ToUniTask(this IEnumerator enumerator)
		{
			return default(UniTask);
		}

		public static UniTask ConfigureAwait(this IEnumerator enumerator, PlayerLoopTiming timing = PlayerLoopTiming.Update, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
