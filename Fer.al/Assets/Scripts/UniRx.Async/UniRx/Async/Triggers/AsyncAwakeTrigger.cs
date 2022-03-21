using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncAwakeTrigger : MonoBehaviour
	{
		private class AwakeMonitor : IPlayerLoopItem
		{
			private readonly AsyncAwakeTrigger trigger;

			public AwakeMonitor(AsyncAwakeTrigger trigger)
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}
		}

		private bool called;

		private UniTaskCompletionSource promise;

		private void Awake()
		{
		}

		public UniTask AwakeAsync()
		{
			return default(UniTask);
		}

		private void OnDestroy()
		{
		}
	}
}
