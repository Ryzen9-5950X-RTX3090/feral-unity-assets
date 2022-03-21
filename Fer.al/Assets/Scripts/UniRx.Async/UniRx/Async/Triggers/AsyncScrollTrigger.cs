using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncScrollTrigger : AsyncTriggerBase, IScrollHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<PointerEventData> onScroll;

		private AsyncTriggerPromiseDictionary<PointerEventData> onScrolls;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IScrollHandler.OnScroll(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnScrollAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
