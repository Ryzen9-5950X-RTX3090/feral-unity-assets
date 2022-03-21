using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncSelectTrigger : AsyncTriggerBase, ISelectHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<BaseEventData> onSelect;

		private AsyncTriggerPromiseDictionary<BaseEventData> onSelects;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void ISelectHandler.OnSelect(BaseEventData eventData)
		{
		}

		public UniTask<BaseEventData> OnSelectAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}
	}
}
