using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncMoveTrigger : AsyncTriggerBase, IMoveHandler, IEventSystemHandler
	{
		private AsyncTriggerPromise<AxisEventData> onMove;

		private AsyncTriggerPromiseDictionary<AxisEventData> onMoves;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		void IMoveHandler.OnMove(AxisEventData eventData)
		{
		}

		public UniTask<AxisEventData> OnMoveAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<AxisEventData>);
		}
	}
}
