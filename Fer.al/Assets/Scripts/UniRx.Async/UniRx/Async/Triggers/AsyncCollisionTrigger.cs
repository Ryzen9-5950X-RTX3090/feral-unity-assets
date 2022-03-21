using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncCollisionTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<Collision> onCollisionEnter;

		private AsyncTriggerPromiseDictionary<Collision> onCollisionEnters;

		private AsyncTriggerPromise<Collision> onCollisionExit;

		private AsyncTriggerPromiseDictionary<Collision> onCollisionExits;

		private AsyncTriggerPromise<Collision> onCollisionStay;

		private AsyncTriggerPromiseDictionary<Collision> onCollisionStays;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		public UniTask<Collision> OnCollisionEnterAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collision>);
		}

		private void OnCollisionExit(Collision collisionInfo)
		{
		}

		public UniTask<Collision> OnCollisionExitAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collision>);
		}

		private void OnCollisionStay(Collision collisionInfo)
		{
		}

		public UniTask<Collision> OnCollisionStayAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collision>);
		}
	}
}
