using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public abstract class LazyLayoutGroup : MonoBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
	{
		public Action OnLayoutRecalculated;

		[SerializeField]
		protected RectOffset m_Padding;

		[SerializeField]
		protected TextAnchor m_ChildAlignment;

		[NonSerialized]
		private RectTransform m_Rect;

		private Vector2 m_TotalMinSize;

		private Vector2 m_TotalPreferredSize;

		private Vector2 m_TotalFlexibleSize;

		private List<LazyLayoutElement> m_childrenElements;

		private List<LazyLayoutElement> m_trackedChildrenElements;

		[SerializeField]
		private bool _createChildrenFromHierarchy;

		protected bool m_IsDirty;

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

		public List<LazyLayoutElement> childrenElements
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected List<LazyLayoutElement> trackedChildrenElements
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

		protected virtual void Start()
		{
		}

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

		protected void SetChildAlongAxis(LazyLayoutElement element, int axis, float pos)
		{
		}

		protected void SetChildAlongAxis(LazyLayoutElement element, int axis, float pos, float size)
		{
		}

		protected void SetProperty<T>(ref T currentValue, T newValue)
		{
		}

		[ContextMenu("Set Dirty")]
		[DeMethodButton(null, 0, new object[] { })]
		public void SetDirty()
		{
		}

		public void SetChildActive(Transform inTransform, bool inActive, bool inAllowMoveToEndOfList = true)
		{
		}

		public void SetSiblingIndexSoft(Transform inTransform, int inSiblingIndex)
		{
		}

		public void SetSiblingIndex(Transform inTransform, int inSiblingIndex)
		{
		}

		public void SetSiblingIndexSoft(LazyLayoutElement inLayoutElement, int inSiblingIndex)
		{
		}

		public void SetSiblingIndex(LazyLayoutElement inLayoutElement, int inSiblingIndex)
		{
		}

		public void ApplySiblingIndicies()
		{
		}

		public void SetSiblingIndexesFromListIndex()
		{
		}

		public void SetAsLastSibling(Transform inTransform)
		{
		}

		public void SetAsLastSibling(LazyLayoutElement inElement)
		{
		}

		public void SetAsLastSiblingSoft(Transform inTransform)
		{
		}

		public void SetAsLastSiblingSoft(LazyLayoutElement inElement)
		{
		}

		public LazyLayoutElement GetChild(Transform inTransform)
		{
			return null;
		}

		public LazyLayoutElement GetChild(RectTransform inTransform)
		{
			return null;
		}

		public int GetTrackedSiblingIndex(LazyLayoutElement inElement)
		{
			return default(int);
		}

		public int GetTrackedSiblingIndex(RectTransform inTransform)
		{
			return default(int);
		}

		public int GetTrackedSiblingIndex(Transform inTransform)
		{
			return default(int);
		}

		public LazyLayoutElement AddChild(RectTransform inTransform)
		{
			return null;
		}

		public void AddChild(LazyLayoutElement inLazyLayoutElement)
		{
		}

		public void RemoveChild(Transform inTransform)
		{
		}

		public void RemoveChild(RectTransform inTransform)
		{
		}

		public void RemoveChild(LazyLayoutElement inLayoutElement)
		{
		}

		[IteratorStateMachine(typeof(<DelayedSetDirty>d__78))]
		private IEnumerator DelayedSetDirty(RectTransform rectTransform)
		{
			return null;
		}
	}
}
