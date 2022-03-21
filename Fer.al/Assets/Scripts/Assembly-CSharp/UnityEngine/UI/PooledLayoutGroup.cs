using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
	[RequireComponent(typeof(RectTransform))]
	public abstract class PooledLayoutGroup : MonoBehaviour, ILayoutElement
	{
		[SerializeField]
		protected RectOffset m_Padding;

		[SerializeField]
		protected TextAnchor m_ChildAlignment;

		[NonSerialized]
		private RectTransform m_Rect;

		protected DrivenRectTransformTracker m_Tracker;

		private Vector2 m_TotalMinSize;

		private Vector2 m_TotalPreferredSize;

		private Vector2 m_TotalFlexibleSize;

		[NonSerialized]
		private List<PooledLayoutElement> m_childrenElements;

		private List<PooledLayoutElement> m_trackedChildrenElements;

		protected bool m_IsDirty;

		public float minVisiblePosition;

		public float maxVisiblePosition;

		public RectOffset padding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextAnchor childAlignment
		{
			get
			{
				return default(TextAnchor);
			}
			set
			{
			}
		}

		protected RectTransform rectTransform
		{
			get
			{
				return null;
			}
		}

		public List<PooledLayoutElement> childrenElements
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected List<PooledLayoutElement> trackedChildrenElements
		{
			get
			{
				return null;
			}
		}

		public virtual float minWidth
		{
			get
			{
				return default(float);
			}
		}

		public virtual float preferredWidth
		{
			get
			{
				return default(float);
			}
		}

		public virtual float flexibleWidth
		{
			get
			{
				return default(float);
			}
		}

		public virtual float minHeight
		{
			get
			{
				return default(float);
			}
		}

		public virtual float preferredHeight
		{
			get
			{
				return default(float);
			}
		}

		public virtual float flexibleHeight
		{
			get
			{
				return default(float);
			}
		}

		public virtual int layoutPriority
		{
			get
			{
				return default(int);
			}
		}

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public abstract void CalculateLayoutInputVertical();

		public abstract void SetLayoutHorizontal();

		public abstract void SetLayoutVertical();

		protected virtual void Reset()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected float GetTotalMinSize(int axis)
		{
			return default(float);
		}

		protected float GetTotalPreferredSize(int axis)
		{
			return default(float);
		}

		protected float GetTotalFlexibleSize(int axis)
		{
			return default(float);
		}

		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
		{
			return default(float);
		}

		protected float GetAlignmentOnAxis(int axis)
		{
			return default(float);
		}

		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
		{
		}

		protected void SetChildAlongAxis(PooledLayoutElement element, int axis, float pos)
		{
		}

		protected void SetChildAlongAxis(PooledLayoutElement element, int axis, float pos, float size)
		{
		}

		protected void SetProperty<T>(ref T currentValue, T newValue)
		{
		}

		[ContextMenu("Set Dirty")]
		public void SetDirty()
		{
		}

		[IteratorStateMachine(typeof(<DelayedSetDirty>d__57))]
		private IEnumerator DelayedSetDirty(RectTransform rectTransform)
		{
			return null;
		}
	}
}
