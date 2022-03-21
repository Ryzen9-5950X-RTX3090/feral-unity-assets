using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncPointerUpTrigger : AsyncTriggerBase, IPointerUpHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<PointerEventData> onPointerUp;

		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerUps;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnPointerUpAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
