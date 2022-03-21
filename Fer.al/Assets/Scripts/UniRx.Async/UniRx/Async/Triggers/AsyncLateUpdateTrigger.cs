using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncLateUpdateTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<AsyncUnit> lateUpdate;

		private AsyncTriggerPromiseDictionary<AsyncUnit> lateUpdates;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		public UniTask LateUpdateAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
