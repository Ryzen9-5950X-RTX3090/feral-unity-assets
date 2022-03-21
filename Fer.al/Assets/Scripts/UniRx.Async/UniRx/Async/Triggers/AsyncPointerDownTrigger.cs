using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncPointerDownTrigger : AsyncTriggerBase, IPointerDownHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<PointerEventData> onPointerDown;

		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerDowns;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnPointerDownAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
