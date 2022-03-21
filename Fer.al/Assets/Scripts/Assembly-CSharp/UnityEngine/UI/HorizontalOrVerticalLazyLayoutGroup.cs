namespace UnityEngine.UI
{
	[ExecuteAlways]
	public abstract class HorizontalOrVerticalLazyLayoutGroup : LazyLayoutGroup
	{
		[SerializeField]
		protected float m_Spacing;

		[SerializeField]
		protected bool m_ChildForceExpandWidth;

		[SerializeField]
		protected bool m_ChildForceExpandHeight;

		[SerializeField]
		protected bool m_ChildControlWidth;

		[SerializeField]
		protected bool m_ChildControlHeight;

		public float spacing
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool childForceExpandWidth
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool childForceExpandHeight
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool childControlWidth
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool childControlHeight
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		protected void CalcAlongAxis(int axis, bool isVertical)
		{
		}

		protected void SetChildrenAlongAxis(int axis, bool isVertical)
		{
		}

		private void GetChildSizes(LazyLayoutElement child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
		{
		}
	}
}
