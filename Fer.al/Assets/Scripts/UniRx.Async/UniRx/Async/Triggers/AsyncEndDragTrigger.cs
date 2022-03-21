using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncEndDragTrigger : AsyncTriggerBase, IEndDragHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<PointerEventData> onEndDrag;

		private AsyncTriggerPromiseDictionary<PointerEventData> onEndDrags;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IEndDragHandler.OnEndDrag(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnEndDragAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
