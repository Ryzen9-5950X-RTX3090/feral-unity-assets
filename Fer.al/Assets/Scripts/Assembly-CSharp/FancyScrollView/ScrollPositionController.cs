using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace FancyScrollView
{
	public class ScrollPositionController : UIBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		private enum ScrollDirection
		{
			Vertical,
			Horizontal
		}

		public enum MovementType
		{
			Unrestricted,
			Elastic,
			Clamped
		}

		[Serializable]
		private struct Snap
		{
			public bool Enable;

			public float VelocityThreshold;

			public float Duration;
		}

		private class AutoScrollState
		{
			public bool Enable;

			public bool Elastic;

			public float Duration;

			public float StartTime;

			public float EndScrollPosition;

			public void Reset()
			{
			}
		}

		[SerializeField]
		private RectTransform viewport;

		[SerializeField]
		private ScrollDirection directionOfRecognize;

		[SerializeField]
		public MovementType movementType;

		[SerializeField]
		private float elasticity;

		[SerializeField]
		private float scrollSensitivity;

		[SerializeField]
		private bool inertia;

		[SerializeField]
		[Tooltip("Only used when inertia is enabled")]
		private float decelerationRate;

		[SerializeField]
		[Tooltip("Only used when inertia is enabled")]
		private Snap snap;

		[SerializeField]
		private int dataCount;

		private float _cellPadding;

		private readonly AutoScrollState autoScrollState;

		private Action<float> onUpdatePosition;

		private Action<int> onItemSelected;

		private Vector2 pointerStartLocalPosition;

		private float dragStartScrollPosition;

		private float prevScrollPosition;

		private float currentScrollPosition;

		private bool dragging;

		private float velocity;

		public void OnUpdatePosition(Action<float> onUpdatePosition)
		{
		}

		public void OnItemSelected(Action<int> onItemSelected)
		{
		}

		public void SetDataCount(int dataCount, bool inPaddingNeeded = false)
		{
		}

		public void ScrollTo(int index, float duration)
		{
		}

		public void JumpTo(int index)
		{
		}

		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
		{
		}

		void IDragHandler.OnDrag(PointerEventData eventData)
		{
		}

		void IEndDragHandler.OnEndDrag(PointerEventData eventData)
		{
		}

		private float GetViewportSize()
		{
			return default(float);
		}

		private float CalculateOffset(float position)
		{
			return default(float);
		}

		private void UpdatePosition(float position)
		{
		}

		private void ItemSelected(int index)
		{
		}

		private float RubberDelta(float overStretching, float viewSize)
		{
			return default(float);
		}

		private void Update()
		{
		}

		private int CalculateDestinationIndex(int index)
		{
			return default(int);
		}

		private int CalculateClosestIndex(int index)
		{
			return default(int);
		}

		private float GetCircularPosition(float position, int length)
		{
			return default(float);
		}

		private float EaseInOutCubic(float start, float end, float value)
		{
			return default(float);
		}
	}
}
