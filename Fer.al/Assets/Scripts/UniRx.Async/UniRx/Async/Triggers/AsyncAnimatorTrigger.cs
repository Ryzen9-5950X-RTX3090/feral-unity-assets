using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncAnimatorTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<int> onAnimatorIK;

		private AsyncTriggerPromiseDictionary<int> onAnimatorIKs;

		private AsyncTriggerPromise<AsyncUnit> onAnimatorMove;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onAnimatorMoves;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnAnimatorIK(int layerIndex)
		{
		}

		public UniTask<int> OnAnimatorIKAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		private void OnAnimatorMove()
		{
		}

		public UniTask OnAnimatorMoveAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
