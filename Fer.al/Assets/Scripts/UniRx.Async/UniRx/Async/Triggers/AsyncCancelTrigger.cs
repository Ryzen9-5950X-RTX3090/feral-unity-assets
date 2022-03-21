using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncCancelTrigger : AsyncTriggerBase, ICancelHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<BaseEventData> onCancel;

		private AsyncTriggerPromiseDictionary<BaseEventData> onCancels;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void ICancelHandler.OnCancel(BaseEventData eventData)
		{
		}

		public UniTask<BaseEventData> OnCancelAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}
	}
}
