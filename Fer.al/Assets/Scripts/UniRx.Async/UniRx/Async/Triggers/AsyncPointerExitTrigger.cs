using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncPointerExitTrigger : AsyncTriggerBase, IPointerExitHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<PointerEventData> onPointerExit;

		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerExits;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnPointerExitAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
