using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncTriggerTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<Collider> onTriggerEnter;

		private AsyncTriggerPromiseDictionary<Collider> onTriggerEnters;

		private AsyncTriggerPromise<Collider> onTriggerExit;

		private AsyncTriggerPromiseDictionary<Collider> onTriggerExits;

		private AsyncTriggerPromise<Collider> onTriggerStay;

		private AsyncTriggerPromiseDictionary<Collider> onTriggerStays;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public UniTask<Collider> OnTriggerEnterAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collider>);
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public UniTask<Collider> OnTriggerExitAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collider>);
		}

		private void OnTriggerStay(Collider other)
		{
		}

		public UniTask<Collider> OnTriggerStayAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collider>);
		}
	}
}
