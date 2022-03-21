using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncPointerEnterTrigger : AsyncTriggerBase, IPointerEnterHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<PointerEventData> onPointerEnter;

		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerEnters;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnPointerEnterAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
