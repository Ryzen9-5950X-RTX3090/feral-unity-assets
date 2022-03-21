using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncParticleTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<GameObject> onParticleCollision;

		private AsyncTriggerPromiseDictionary<GameObject> onParticleCollisions;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnParticleCollision(GameObject other)
		{
		}

		public UniTask<GameObject> OnParticleCollisionAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<GameObject>);
		}
	}
}
