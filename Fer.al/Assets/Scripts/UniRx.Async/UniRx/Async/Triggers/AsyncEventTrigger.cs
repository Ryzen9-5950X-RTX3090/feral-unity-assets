using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncEventTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<BaseEventData> onDeselect;

		private AsyncTriggerPromiseDictionary<BaseEventData> onDeselects;

		private AsyncTriggerPromise<AxisEventData> onMove;

		private AsyncTriggerPromiseDictionary<AxisEventData> onMoves;

		private AsyncTriggerPromise<PointerEventData> onPointerDown;

		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerDowns;

		private AsyncTriggerPromise<PointerEventData> onPointerEnter;

		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerEnters;

		private AsyncTriggerPromise<PointerEventData> onPointerExit;

		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerExits;

		private AsyncTriggerPromise<PointerEventData> onPointerUp;

		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerUps;

		private AsyncTriggerPromise<BaseEventData> onSelect;

		private AsyncTriggerPromiseDictionary<BaseEventData> onSelects;

		private AsyncTriggerPromise<PointerEventData> onPointerClick;

		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerClicks;

		private AsyncTriggerPromise<BaseEventData> onSubmit;

		private AsyncTriggerPromiseDictionary<BaseEventData> onSubmits;

		private AsyncTriggerPromise<PointerEventData> onDrag;

		private AsyncTriggerPromiseDictionary<PointerEventData> onDrags;

		private AsyncTriggerPromise<PointerEventData> onBeginDrag;

		private AsyncTriggerPromiseDictionary<PointerEventData> onBeginDrags;

		private AsyncTriggerPromise<PointerEventData> onEndDrag;

		private AsyncTriggerPromiseDictionary<PointerEventData> onEndDrags;

		private AsyncTriggerPromise<PointerEventData> onDrop;

		private AsyncTriggerPromiseDictionary<PointerEventData> onDrops;

		private AsyncTriggerPromise<BaseEventData> onUpdateSelected;

		private AsyncTriggerPromiseDictionary<BaseEventData> onUpdateSelecteds;

		private AsyncTriggerPromise<PointerEventData> onInitializePotentialDrag;

		private AsyncTriggerPromiseDictionary<PointerEventData> onInitializePotentialDrags;

		private AsyncTriggerPromise<BaseEventData> onCancel;

		private AsyncTriggerPromiseDictionary<BaseEventData> onCancels;

		private AsyncTriggerPromise<PointerEventData> onScroll;

		private AsyncTriggerPromiseDictionary<PointerEventData> onScrolls;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnDeselect(BaseEventData eventData)
		{
		}

		public UniTask<BaseEventData> OnDeselectAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}

		private void OnMove(AxisEventData eventData)
		{
		}

		public UniTask<AxisEventData> OnMoveAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<AxisEventData>);
		}

		private void OnPointerDown(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnPointerDownAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		private void OnPointerEnter(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnPointerEnterAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		private void OnPointerExit(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnPointerExitAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		private void OnPointerUp(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnPointerUpAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		private void OnSelect(BaseEventData eventData)
		{
		}

		public UniTask<BaseEventData> OnSelectAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}

		private void OnPointerClick(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnPointerClickAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		private void OnSubmit(BaseEventData eventData)
		{
		}

		public UniTask<BaseEventData> OnSubmitAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}

		private void OnDrag(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnDragAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		private void OnBeginDrag(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnBeginDragAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		private void OnEndDrag(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnEndDragAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		private void OnDrop(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnDropAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		private void OnUpdateSelected(BaseEventData eventData)
		{
		}

		public UniTask<BaseEventData> OnUpdateSelectedAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}

		private void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnInitializePotentialDragAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		private void OnCancel(BaseEventData eventData)
		{
		}

		public UniTask<BaseEventData> OnCancelAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}

		private void OnScroll(PointerEventData eventData)
		{
		}

		public UniTask<PointerEventData> OnScrollAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}
	}
}
