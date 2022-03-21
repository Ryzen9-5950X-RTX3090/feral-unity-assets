using System.Collections.Generic;
using DG.DeInspektor.Attributes;
using DG.Tweening;
using Unitilities.Tuples;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using WW.Waiters;

public class WWSmoothLayout : MonoBehaviour
{
	public class RectPair : Tuple<RectTransform, RectTransform>
	{
		private int _framesToSnap;

		public bool _snapHeight;

		public Vector2 targetAnchoredPosition;

		public Vector2 targetSizeDelta;

		public RectTransform TargetRect
		{
			get
			{
				return null;
			}
		}

		public RectTransform SrcRect
		{
			get
			{
				return null;
			}
		}

		public int FramesToSnap
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public RectPair(RectTransform inTargetRect, RectTransform inSrcRect)
		{
		}
	}

	[SerializeField]
	private RectTransform _targetParent;

	[SerializeField]
	private RectTransform _srcParent;

	[SerializeField]
	private bool _initFromExistingHeirarchy;

	[SerializeField]
	[FormerlySerializedAs("_resizeSelf")]
	private bool _animatedResizeSelf;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private float _animationDuration;

	private List<RectPair> _rectPairs;

	private bool _isSetup;

	private bool _isDirty;

	private WW.Waiters.Waiter _markDirtyWaiter;

	private float _quickMoveRequestTime;

	private Tweener _scrollTween;

	public ScrollRect ScrollRect
	{
		get
		{
			return null;
		}
	}

	public float AnimationDuration
	{
		get
		{
			return default(float);
		}
	}

	public bool IsResizing
	{
		get
		{
			return default(bool);
		}
	}

	private bool DoQuickMove
	{
		get
		{
			return default(bool);
		}
	}

	public void AddChild(RectTransform inChild)
	{
	}

	public void RemoveChild(int inChildIndex, bool inDestroy)
	{
	}

	public void RemoveChild(RectTransform inChild, bool inDestroy)
	{
	}

	public void SetChildActive(int inChildIndex, bool inActive, bool inSnapPosition = true)
	{
	}

	public void SetChildActive(RectTransform inChild, bool inActive, bool inSnapPosition = true)
	{
	}

	public void SetSiblingIndex(RectTransform inChild, int inChildIndex)
	{
	}

	public void SetAsLastSibling(RectTransform inChild)
	{
	}

	public RectPair GetRectPair(int inChildIndex)
	{
		return null;
	}

	public RectPair GetRectPair(RectTransform inChild)
	{
		return null;
	}

	public void ScrollToItem(RectTransform inChild)
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void MarkAsDirty()
	{
	}

	public void RequestQuickTime()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void RemoveFirstChild()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void RemoveLastChild()
	{
	}

	private void Start()
	{
	}

	public void Setup()
	{
	}

	private void LateUpdate()
	{
	}
}
