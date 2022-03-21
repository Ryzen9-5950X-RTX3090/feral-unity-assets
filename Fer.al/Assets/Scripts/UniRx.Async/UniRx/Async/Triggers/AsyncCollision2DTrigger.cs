using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncCollision2DTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<Collision2D> onCollisionEnter2D;

		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionEnter2Ds;

		private AsyncTriggerPromise<Collision2D> onCollisionExit2D;

		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionExit2Ds;

		private AsyncTriggerPromise<Collision2D> onCollisionStay2D;

		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionStay2Ds;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnCollisionEnter2D(Collision2D coll)
		{
		}

		public UniTask<Collision2D> OnCollisionEnter2DAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collision2D>);
		}

		private void OnCollisionExit2D(Collision2D coll)
		{
		}

		public UniTask<Collision2D> OnCollisionExit2DAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collision2D>);
		}

		private void OnCollisionStay2D(Collision2D coll)
		{
		}

		public UniTask<Collision2D> OnCollisionStay2DAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collision2D>);
		}
	}
}
