using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async.Internal;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	public abstract class AsyncTriggerBase : MonoBehaviour
	{
		private class AwakeMonitor : IPlayerLoopItem
		{
			private readonly AsyncTriggerBase trigger;

			public AwakeMonitor(AsyncTriggerBase trigger)
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}
		}

		private static readonly Action<object> Callback;

		private bool calledAwake;

		private bool destroyCalled;

		private CancellationTokenRegistration[] registeredCancellations;

		private int registeredCancellationsCount;

		protected abstract IEnumerable<ICancelablePromise> GetPromises();

		[IteratorStateMachine(typeof(<Concat>d__6))]
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Concat>d__7))]
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Concat>d__8))]
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s, ICancelablePromise p3, IEnumerable<ICancelablePromise> p3s)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Concat>d__9))]
		protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s, ICancelablePromise p3, IEnumerable<ICancelablePromise> p3s, ICancelablePromise p4, IEnumerable<ICancelablePromise> p4s)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Concat>d__10))]
		protected static IEnumerable<ICancelablePromise> Concat(object[] promises)
		{
			return null;
		}

		protected UniTask<T> GetOrAddPromise<T>(ref AsyncTriggerPromise<T> promise, ref AsyncTriggerPromiseDictionary<T> promises, CancellationToken cancellationToken)
		{
			return default(UniTask<T>);
		}

		private static void CancelCallback(object state)
		{
		}

		protected void TrySetResult<T>(ReusablePromise<T> promise, AsyncTriggerPromiseDictionary<T> promises, T value)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
