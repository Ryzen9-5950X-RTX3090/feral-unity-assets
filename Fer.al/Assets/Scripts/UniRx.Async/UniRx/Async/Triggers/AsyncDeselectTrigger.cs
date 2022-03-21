using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncDeselectTrigger : AsyncTriggerBase, IDeselectHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<BaseEventData> onDeselect;

		private AsyncTriggerPromiseDictionary<BaseEventData> onDeselects;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IDeselectHandler.OnDeselect(BaseEventData eventData)
		{
		}

		public UniTask<BaseEventData> OnDeselectAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}
	}
}
