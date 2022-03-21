using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncTransformChangedTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<AsyncUnit> onBeforeTransformParentChanged;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onBeforeTransformParentChangeds;

		private AsyncTriggerPromise<AsyncUnit> onTransformParentChanged;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onTransformParentChangeds;

		private AsyncTriggerPromise<AsyncUnit> onTransformChildrenChanged;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onTransformChildrenChangeds;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnBeforeTransformParentChanged()
		{
		}

		public UniTask OnBeforeTransformParentChangedAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		private void OnTransformParentChanged()
		{
		}

		public UniTask OnTransformParentChangedAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		private void OnTransformChildrenChanged()
		{
		}

		public UniTask OnTransformChildrenChangedAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
