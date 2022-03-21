using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	public static class AsyncTriggerExtensions
	{
		private static T GetOrAddComponent<T>(GameObject gameObject) where T : Component
		{
			return null;
		}

		public static UniTask OnDestroyAsync(this GameObject gameObject)
		{
			return default(UniTask);
		}

		public static UniTask OnDestroyAsync(this Component component)
		{
			return default(UniTask);
		}

		public static CancellationToken GetCancellationTokenOnDestroy(this GameObject gameObject)
		{
			return default(CancellationToken);
		}

		public static CancellationToken GetCancellationTokenOnDestroy(this Component component)
		{
			return default(CancellationToken);
		}

		public static UniTask StartAsync(this GameObject gameObject)
		{
			return default(UniTask);
		}

		public static UniTask StartAsync(this Component component)
		{
			return default(UniTask);
		}

		public static UniTask AwakeAsync(this GameObject gameObject)
		{
			return default(UniTask);
		}

		public static UniTask AwakeAsync(this Component component)
		{
			return default(UniTask);
		}

		public static AsyncAnimatorTrigger GetAsyncAnimatorTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncAnimatorTrigger GetAsyncAnimatorTrigger(this Component component)
		{
			return null;
		}

		public static AsyncAwakeTrigger GetAsyncAwakeTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncAwakeTrigger GetAsyncAwakeTrigger(this Component component)
		{
			return null;
		}

		public static AsyncBeginDragTrigger GetAsyncBeginDragTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncBeginDragTrigger GetAsyncBeginDragTrigger(this Component component)
		{
			return null;
		}

		public static AsyncCancelTrigger GetAsyncCancelTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncCancelTrigger GetAsyncCancelTrigger(this Component component)
		{
			return null;
		}

		public static AsyncCanvasGroupChangedTrigger GetAsyncCanvasGroupChangedTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncCanvasGroupChangedTrigger GetAsyncCanvasGroupChangedTrigger(this Component component)
		{
			return null;
		}

		public static AsyncCollision2DTrigger GetAsyncCollision2DTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncCollision2DTrigger GetAsyncCollision2DTrigger(this Component component)
		{
			return null;
		}

		public static AsyncCollisionTrigger GetAsyncCollisionTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncCollisionTrigger GetAsyncCollisionTrigger(this Component component)
		{
			return null;
		}

		public static AsyncDeselectTrigger GetAsyncDeselectTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncDeselectTrigger GetAsyncDeselectTrigger(this Component component)
		{
			return null;
		}

		public static AsyncDestroyTrigger GetAsyncDestroyTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncDestroyTrigger GetAsyncDestroyTrigger(this Component component)
		{
			return null;
		}

		public static AsyncDragTrigger GetAsyncDragTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncDragTrigger GetAsyncDragTrigger(this Component component)
		{
			return null;
		}

		public static AsyncDropTrigger GetAsyncDropTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncDropTrigger GetAsyncDropTrigger(this Component component)
		{
			return null;
		}

		public static AsyncEnableDisableTrigger GetAsyncEnableDisableTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncEnableDisableTrigger GetAsyncEnableDisableTrigger(this Component component)
		{
			return null;
		}

		public static AsyncEndDragTrigger GetAsyncEndDragTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncEndDragTrigger GetAsyncEndDragTrigger(this Component component)
		{
			return null;
		}

		public static AsyncFixedUpdateTrigger GetAsyncFixedUpdateTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncFixedUpdateTrigger GetAsyncFixedUpdateTrigger(this Component component)
		{
			return null;
		}

		public static AsyncInitializePotentialDragTrigger GetAsyncInitializePotentialDragTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncInitializePotentialDragTrigger GetAsyncInitializePotentialDragTrigger(this Component component)
		{
			return null;
		}

		public static AsyncJointTrigger GetAsyncJointTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncJointTrigger GetAsyncJointTrigger(this Component component)
		{
			return null;
		}

		public static AsyncLateUpdateTrigger GetAsyncLateUpdateTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncLateUpdateTrigger GetAsyncLateUpdateTrigger(this Component component)
		{
			return null;
		}

		public static AsyncMouseTrigger GetAsyncMouseTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncMouseTrigger GetAsyncMouseTrigger(this Component component)
		{
			return null;
		}

		public static AsyncMoveTrigger GetAsyncMoveTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncMoveTrigger GetAsyncMoveTrigger(this Component component)
		{
			return null;
		}

		public static AsyncParticleTrigger GetAsyncParticleTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncParticleTrigger GetAsyncParticleTrigger(this Component component)
		{
			return null;
		}

		public static AsyncPointerClickTrigger GetAsyncPointerClickTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncPointerClickTrigger GetAsyncPointerClickTrigger(this Component component)
		{
			return null;
		}

		public static AsyncPointerDownTrigger GetAsyncPointerDownTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncPointerDownTrigger GetAsyncPointerDownTrigger(this Component component)
		{
			return null;
		}

		public static AsyncPointerEnterTrigger GetAsyncPointerEnterTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncPointerEnterTrigger GetAsyncPointerEnterTrigger(this Component component)
		{
			return null;
		}

		public static AsyncPointerExitTrigger GetAsyncPointerExitTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncPointerExitTrigger GetAsyncPointerExitTrigger(this Component component)
		{
			return null;
		}

		public static AsyncPointerUpTrigger GetAsyncPointerUpTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncPointerUpTrigger GetAsyncPointerUpTrigger(this Component component)
		{
			return null;
		}

		public static AsyncRectTransformTrigger GetAsyncRectTransformTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncRectTransformTrigger GetAsyncRectTransformTrigger(this Component component)
		{
			return null;
		}

		public static AsyncScrollTrigger GetAsyncScrollTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncScrollTrigger GetAsyncScrollTrigger(this Component component)
		{
			return null;
		}

		public static AsyncSelectTrigger GetAsyncSelectTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncSelectTrigger GetAsyncSelectTrigger(this Component component)
		{
			return null;
		}

		public static AsyncStartTrigger GetAsyncStartTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncStartTrigger GetAsyncStartTrigger(this Component component)
		{
			return null;
		}

		public static AsyncSubmitTrigger GetAsyncSubmitTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncSubmitTrigger GetAsyncSubmitTrigger(this Component component)
		{
			return null;
		}

		public static AsyncTransformChangedTrigger GetAsyncTransformChangedTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncTransformChangedTrigger GetAsyncTransformChangedTrigger(this Component component)
		{
			return null;
		}

		public static AsyncTrigger2DTrigger GetAsyncTrigger2DTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncTrigger2DTrigger GetAsyncTrigger2DTrigger(this Component component)
		{
			return null;
		}

		public static AsyncTriggerTrigger GetAsyncTriggerTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncTriggerTrigger GetAsyncTriggerTrigger(this Component component)
		{
			return null;
		}

		public static AsyncUpdateSelectedTrigger GetAsyncUpdateSelectedTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncUpdateSelectedTrigger GetAsyncUpdateSelectedTrigger(this Component component)
		{
			return null;
		}

		public static AsyncUpdateTrigger GetAsyncUpdateTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncUpdateTrigger GetAsyncUpdateTrigger(this Component component)
		{
			return null;
		}

		public static AsyncVisibleTrigger GetAsyncVisibleTrigger(this GameObject gameObject)
		{
			return null;
		}

		public static AsyncVisibleTrigger GetAsyncVisibleTrigger(this Component component)
		{
			return null;
		}
	}
}
