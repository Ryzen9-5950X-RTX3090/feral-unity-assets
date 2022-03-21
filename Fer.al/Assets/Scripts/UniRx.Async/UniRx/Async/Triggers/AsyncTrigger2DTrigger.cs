using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncTrigger2DTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<Collider2D> onTriggerEnter2D;

		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerEnter2Ds;

		private AsyncTriggerPromise<Collider2D> onTriggerExit2D;

		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerExit2Ds;

		private AsyncTriggerPromise<Collider2D> onTriggerStay2D;

		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerStay2Ds;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		public UniTask<Collider2D> OnTriggerEnter2DAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collider2D>);
		}

		private void OnTriggerExit2D(Collider2D other)
		{
		}

		public UniTask<Collider2D> OnTriggerExit2DAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collider2D>);
		}

		private void OnTriggerStay2D(Collider2D other)
		{
		}

		public UniTask<Collider2D> OnTriggerStay2DAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Collider2D>);
		}
	}
}
