using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncPointerClickTrigger : AsyncTriggerBase, IPointerClickHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<PointerEventData> onPointerClick;

		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerClicks;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnPointerClickAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
