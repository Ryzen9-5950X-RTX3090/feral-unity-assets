using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncStartTrigger : MonoBehaviour
	{
		private class AwakeMonitor : IPlayerLoopItem
		{
			private readonly AsyncStartTrigger trigger;

			public AwakeMonitor(AsyncStartTrigger trigger)
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}
		}

		private bool awakeCalled;

		private bool called;

		private UniTaskCompletionSource promise;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public UniTask StartAsync()
		{
			return default(UniTask);
		}

		private void OnDestroy()
		{
		}
	}
}
