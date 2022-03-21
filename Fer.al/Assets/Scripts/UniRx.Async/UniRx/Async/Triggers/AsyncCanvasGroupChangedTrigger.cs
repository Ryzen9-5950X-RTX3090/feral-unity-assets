using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncCanvasGroupChangedTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<AsyncUnit> onCanvasGroupChanged;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onCanvasGroupChangeds;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnCanvasGroupChanged()
		{
		}

		public UniTask OnCanvasGroupChangedAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
