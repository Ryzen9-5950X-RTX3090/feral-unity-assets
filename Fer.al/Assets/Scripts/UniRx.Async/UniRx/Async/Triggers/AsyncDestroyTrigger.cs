using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncDestroyTrigger : MonoBehaviour
	{
		private bool called;

		private UniTaskCompletionSource promise;

		private CancellationTokenSource cancellationTokenSource;

		private object canellationTokenSourceOrQueue;

		public CancellationToken CancellationToken
		{
			get
			{
				return default(CancellationToken);
			}
		}

		private void OnDestroy()
		{
		}

		public UniTask OnDestroyAsync()
		{
			return default(UniTask);
		}

		public void AddCancellationTriggerOnDestory(CancellationTokenSource cts)
		{
		}
	}
}
