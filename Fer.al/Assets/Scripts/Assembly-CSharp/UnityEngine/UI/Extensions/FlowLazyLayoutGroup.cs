using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	[ExecuteAlways]
	[AddComponentMenu("Layout/Extensions/Flow Lazy Layout Group")]
	public class FlowLazyLayoutGroup : LazyLayoutGroup
	{
		public enum Axis
		{
			Horizontal,
			Vertical
		}

		public float SpacingX;

		public float SpacingY;

		public bool ExpandHorizontalSpacing;

		public bool ExpandPadding;

		public bool ChildForceExpandWidth;

		public bool ChildForceExpandHeight;

		public bool invertOrder;

		private float _layoutHeight;

		private float _layoutWidth;

		private float _extraPadding;

		[SerializeField]
		protected Axis m_StartAxis;

		private readonly IList<LazyLayoutElement> _itemList;

		public Axis startAxis
		{
			get
			{
				return default(Axis);
			}
			set
			{
			}
		}

		protected bool IsCenterAlign
		{
			get
			{
				return default(bool);
			}
		}

		protected bool IsRightAlign
		{
			get
			{
				return default(bool);
			}
		}

		protected bool IsMiddleAlign
		{
			get
			{
				return default(bool);
			}
		}

		protected bool IsLowerAlign
		{
			get
			{
				return default(bool);
			}
		}

		public override void CalculateLayoutInputHorizontal()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public float SetLayout(int axis, bool layoutInput)
		{
			return default(float);
		}

		private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight)
		{
			return default(float);
		}

		private float CalculateColHorizontalOffset(float groupWidth, float xOffset, float currentColWidth)
		{
			return default(float);
		}

		protected void LayoutRow(IList<LazyLayoutElement> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis)
		{
		}

		protected void LayoutCol(IList<LazyLayoutElement> contents, float colWidth, float colHeight, float maxHeight, float xOffset, float yOffset, int axis)
		{
		}

		public float GetGreatestMinimumChildWidth()
		{
			return default(float);
		}

		public float GetGreatestMinimumChildHeight()
		{
			return default(float);
		}
	}
}
