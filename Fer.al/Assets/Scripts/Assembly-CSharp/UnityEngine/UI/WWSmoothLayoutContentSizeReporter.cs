using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[AddComponentMenu("Layout/Smooth Layout Content Size Reporter", 141)]
	[RequireComponent(typeof(RectTransform))]
	public class WWSmoothLayoutContentSizeReporter : UIBehaviour, ILayoutSelfController, ILayoutController
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
		protected float m_PreferredWidthOverride;

		[SerializeField]
		protected bool m_ResetWidthOnEnable;

		[SerializeField]
		protected FitMode m_VerticalFit;

		[SerializeField]
		protected float m_PreferredHeightOverride;

		[SerializeField]
		protected bool m_ResetHeightOnEnable;

		[NonSerialized]
		private RectTransform m_Rect;

		private DrivenRectTransformTracker m_Tracker;

		private LayoutElement _srcLayoutElement;

		private WWSmoothLayout _smoothLayout;

		private bool _hadSizeChange;

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

		protected WWSmoothLayoutContentSizeReporter()
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

		public void Setup(LayoutElement inSrcLayoutElement, WWSmoothLayout inSmoothLayout)
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
