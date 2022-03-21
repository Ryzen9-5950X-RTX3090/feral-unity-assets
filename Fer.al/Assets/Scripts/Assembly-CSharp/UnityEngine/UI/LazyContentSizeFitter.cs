using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[AddComponentMenu("Layout/Lazy Content Size Fitter", 141)]
	[RequireComponent(typeof(RectTransform))]
	public class LazyContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		public enum FitMode
		{
			Unconstrained,
			MinSize,
			PreferredSize
		}

		[SerializeField]
		protected FitMode m_HorizontalFit;

		[SerializeField]
		protected bool _resetWidthOnDisable;

		[SerializeField]
		protected bool _animateWidth;

		[SerializeField]
		protected FitMode m_VerticalFit;

		[SerializeField]
		protected bool _resetHeightOnDisable;

		[SerializeField]
		protected bool _animateHeight;

		[NonSerialized]
		private RectTransform m_Rect;

		public LazyLayoutGroup _layout;

		private LazyLayoutElement _targetElement;

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

		public LazyLayoutElement TargetElement
		{
			get
			{
				return null;
			}
		}

		protected LazyContentSizeFitter()
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
