using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncSubmitTrigger : AsyncTriggerBase, ISubmitHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<BaseEventData> onSubmit;

		private AsyncTriggerPromiseDictionary<BaseEventData> onSubmits;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void ISubmitHandler.OnSubmit(BaseEventData eventData)
		{
		}

		public UniTask<BaseEventData> OnSubmitAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}
	}
}
