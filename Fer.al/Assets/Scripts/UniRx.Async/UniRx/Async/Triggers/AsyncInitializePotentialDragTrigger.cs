using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncInitializePotentialDragTrigger : AsyncTriggerBase, IInitializePotentialDragHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<PointerEventData> onInitializePotentialDrag;

		private AsyncTriggerPromiseDictionary<PointerEventData> onInitializePotentialDrags;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnInitializePotentialDragAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
