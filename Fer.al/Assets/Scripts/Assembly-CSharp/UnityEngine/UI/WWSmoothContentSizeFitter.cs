using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[AddComponentMenu("Layout/Smooth Content Size Fitter", 141)]
	[RequireComponent(typeof(RectTransform))]
	public class WWSmoothContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		public enum FitMode
		{
			Unconstrained,
			MinSize,
			PreferredSize
		}

		[SerializeField]
		protected float _animationTime;

		[SerializeField]
		protected FitMode m_HorizontalFit;

		[SerializeField]
		protected float _maxHorizontalSize;

		[SerializeField]
		protected FitMode m_VerticalFit;

		[SerializeField]
		protected float _maxVerticalSize;

		public bool animationEnabled;

		[NonSerialized]
		private RectTransform m_Rect;

		private DrivenRectTransformTracker m_Tracker;

		private Vector2 _currentTargetSize;

		public FitMode horizontalFit
		{
			get
			{
				return default(FitMode);
			}
			set
			{
			}
		}

		public FitMode verticalFit
		{
			get
			{
				return default(FitMode);
			}
			set
			{
			}
		}

		private RectTransform rectTransform
		{
			get
			{
				return null;
			}
		}

		protected WWSmoothContentSizeFitter()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void HandleSelfFittingAlongAxis(int axis)
		{
		}

		public virtual void SetLayoutHorizontal()
		{
		}

		public virtual void SetLayoutVertical()
		{
		}

		protected void SetDirty()
		{
		}
	}
}
