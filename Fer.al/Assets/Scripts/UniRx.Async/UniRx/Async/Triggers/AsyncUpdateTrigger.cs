using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncUpdateTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<AsyncUnit> update;

		private AsyncTriggerPromiseDictionary<AsyncUnit> updates;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void Update()
		{
		}

		public UniTask UpdateAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
