using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncFixedUpdateTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<AsyncUnit> fixedUpdate;

		private AsyncTriggerPromiseDictionary<AsyncUnit> fixedUpdates;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void FixedUpdate()
		{
		}

		public UniTask FixedUpdateAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
