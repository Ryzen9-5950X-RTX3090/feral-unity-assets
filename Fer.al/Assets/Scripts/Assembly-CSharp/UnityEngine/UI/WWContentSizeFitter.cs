using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	[AddComponentMenu("Layout/WW Content Size Fitter", 141)]
	[RequireComponent(typeof(RectTransform))]
	public class WWContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
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
		protected float m_MaxWidth;

		[SerializeField]
		protected float m_MinWidth;

		[SerializeField]
		protected FitMode m_VerticalFit;

		[SerializeField]
		protected float m_MaxHeight;

		[SerializeField]
		protected float m_MinHeight;

		[NonSerialized]
		private RectTransform m_Rect;

		private DrivenRectTransformTracker m_Tracker;

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

		public float MaxWidth
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float MinWidth
		{
			get
			{
				return default(float);
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

		public float MaxHeight
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float MinHeight
		{
			get
			{
				return default(float);
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

		protected WWContentSizeFitter()
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
