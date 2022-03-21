using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncUpdateSelectedTrigger : AsyncTriggerBase, IUpdateSelectedHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<BaseEventData> onUpdateSelected;

		private AsyncTriggerPromiseDictionary<BaseEventData> onUpdateSelecteds;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData)
		{
		}

		public UniTask<BaseEventData> OnUpdateSelectedAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}
	}
}
