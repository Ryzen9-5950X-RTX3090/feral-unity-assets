using System.Collections.Generic;

namespace UnityEngine.UI
{
	[AddComponentMenu("Layout/Pooled Grid Layout Group", 153)]
	public class PooledGridLayoutGroup : LayoutGroup
	{
		public enum Corner
		{
			UpperLeft,
			UpperRight,
			LowerLeft,
			LowerRight
		}

		public enum Axis
		{
			Horizontal,
			Vertical
		}

		public enum Constraint
		{
			FixedColumnCount,
			FixedRowCount,
			Flexible
		}

		[SerializeField]
		protected int m_ItemCount;

		[SerializeField]
		protected float m_ViewportOverflow;

		[SerializeField]
		protected PooledGridLayoutElement m_ItemPrefab;

		protected List<PooledGridLayoutElement> m_LayoutElements;

		[SerializeField]
		protected ScrollRect m_ScrollRect;

		protected float m_LastHorizontalScrollbarValue;

		protected float m_LastVerticalScrollbarValue;

		protected int m_FittableElements;

		protected int m_LowerElementIndex;

		protected bool m_indicesChangedLastCheck;

		protected bool m_indiciesCheckedThisFrame;

		protected bool m_initialized;

		protected bool m_ignoreNextScrollbarUpdate;

		protected bool m_ignroeNextScrollRectUpdate;

		[SerializeField]
		protected Corner m_StartCorner;

		[SerializeField]
		protected Axis m_StartAxis;

		[SerializeField]
		protected Vector2 m_CellSize;

		[SerializeField]
		protected Vector2 m_Spacing;

		[SerializeField]
		protected Constraint m_Constraint;

		[SerializeField]
		protected int m_ConstraintCount;

		protected int m_ColumnCount;

		protected int m_RowCount;

		public int ItemCount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float ViewportOverflow
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public PooledGridLayoutElement ItemPrefab
		{
			get
			{
				return null;
			}
		}

		public ScrollRect ScrollRect
		{
			get
			{
				return null;
			}
		}

		protected int m_UpperElementIndex
		{
			get
			{
				return default(int);
			}
		}

		public Corner startCorner
		{
			get
			{
				return default(Corner);
			}
			set
			{
			}
		}

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

		public Vector2 cellSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 spacing
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Constraint constraint
		{
			get
			{
				return default(Constraint);
			}
			set
			{
			}
		}

		public int constraintCount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		protected PooledGridLayoutGroup()
		{
		}

		public override void CalculateLayoutInputHorizontal()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		private void SetCellsAlongAxis(int axis, bool setSize = true)
		{
		}

		protected override void Awake()
		{
		}

		protected void Initialize()
		{
		}

		protected void LateUpdate()
		{
		}

		public void CreateElements()
		{
		}

		public void RefreshElements()
		{
		}

		public void AutoAssignScrollRect()
		{
		}

		public void AutoSetViewportOverflow()
		{
		}

		public void OnVerticalScrollbarValueChanged(float inValue)
		{
		}

		public void OnHorizontalScrollbarValueChanged(float inValue)
		{
		}

		public void OnScrollRectValueChanged(Vector2 inValue)
		{
		}

		public void UpdateElementIndices(Vector2 moveDirection)
		{
		}

		protected void CalculateVisibleElements()
		{
		}
	}
}
