using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncVisibleTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<AsyncUnit> onBecameInvisible;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onBecameInvisibles;

		private AsyncTriggerPromise<AsyncUnit> onBecameVisible;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onBecameVisibles;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnBecameInvisible()
		{
		}

		public UniTask OnBecameInvisibleAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		private void OnBecameVisible()
		{
		}

		public UniTask OnBecameVisibleAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
