using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncBeginDragTrigger : AsyncTriggerBase, IBeginDragHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<PointerEventData> onBeginDrag;

		private AsyncTriggerPromiseDictionary<PointerEventData> onBeginDrags;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnBeginDragAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
