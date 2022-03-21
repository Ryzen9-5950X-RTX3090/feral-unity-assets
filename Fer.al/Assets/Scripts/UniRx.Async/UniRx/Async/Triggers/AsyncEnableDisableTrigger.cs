using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncEnableDisableTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<AsyncUnit> onEnable;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onEnables;

		private AsyncTriggerPromise<AsyncUnit> onDisable;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onDisables;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnEnable()
		{
		}

		public UniTask OnEnableAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		private void OnDisable()
		{
		}

		public UniTask OnDisableAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
