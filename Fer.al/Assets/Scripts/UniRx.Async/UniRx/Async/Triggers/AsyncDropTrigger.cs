using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncDropTrigger : AsyncTriggerBase, IDropHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<PointerEventData> onDrop;

		private AsyncTriggerPromiseDictionary<PointerEventData> onDrops;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IDropHandler.OnDrop(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnDropAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
