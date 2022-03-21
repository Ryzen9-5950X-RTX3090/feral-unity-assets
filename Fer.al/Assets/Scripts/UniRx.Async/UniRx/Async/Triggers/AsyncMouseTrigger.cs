using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncMouseTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<AsyncUnit> onMouseDown;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseDowns;

		private AsyncTriggerPromise<AsyncUnit> onMouseDrag;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseDrags;

		private AsyncTriggerPromise<AsyncUnit> onMouseEnter;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseEnters;

		private AsyncTriggerPromise<AsyncUnit> onMouseExit;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseExits;

		private AsyncTriggerPromise<AsyncUnit> onMouseOver;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseOvers;

		private AsyncTriggerPromise<AsyncUnit> onMouseUp;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseUps;

		private AsyncTriggerPromise<AsyncUnit> onMouseUpAsButton;

		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseUpAsButtons;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnMouseDown()
		{
		}

		public UniTask OnMouseDownAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		private void OnMouseDrag()
		{
		}

		public UniTask OnMouseDragAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		private void OnMouseEnter()
		{
		}

		public UniTask OnMouseEnterAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		private void OnMouseExit()
		{
		}

		public UniTask OnMouseExitAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		private void OnMouseOver()
		{
		}

		public UniTask OnMouseOverAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		private void OnMouseUp()
		{
		}

		public UniTask OnMouseUpAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		private void OnMouseUpAsButton()
		{
		}

		public UniTask OnMouseUpAsButtonAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
