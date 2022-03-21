using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncRectTransformTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<AsyncUnit> onRectTransformDimensionsChange;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onRectTransformDimensionsChanges;

		private AsyncTriggerPromise<AsyncUnit> onRectTransformRemoved;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onRectTransformRemoveds;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		public UniTask OnRectTransformDimensionsChangeAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		private void OnRectTransformRemoved()
		{
		}

		public UniTask OnRectTransformRemovedAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
