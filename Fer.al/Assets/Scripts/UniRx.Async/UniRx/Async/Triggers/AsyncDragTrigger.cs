using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncDragTrigger : AsyncTriggerBase, IDragHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<PointerEventData> onDrag;

		private AsyncTriggerPromiseDictionary<PointerEventData> onDrags;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IDragHandler.OnDrag(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnDragAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
