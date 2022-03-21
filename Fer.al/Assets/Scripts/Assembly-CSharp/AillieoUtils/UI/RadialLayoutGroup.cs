using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AillieoUtils.UI
{
	public class RadialLayoutGroup : LayoutGroup
	{
		public enum Direction
		{
			Clockwise,
			Counterclockwise,
			Bidirectional
		}

		public enum ConstraintMode
		{
			Interval,
			Range
		}

		[SerializeField]
		private ConstraintMode mAngleConstraint;

		[SerializeField]
		private ConstraintMode mRadiusConstraint;

		[SerializeField]
		private Direction mLayoutDir;

		[SerializeField]
		private float mRadiusStart;

		[SerializeField]
		private float mRadiusDelta;

		[SerializeField]
		private float mRadiusRange;

		[SerializeField]
		private float mAngleDelta;

		[SerializeField]
		private float mAngleStart;

		[SerializeField]
		private float mAngleCenter;

		[SerializeField]
		private float mAngleRange;

		[SerializeField]
		private bool mChildRotate;

		private List<RectTransform> childList;

		private List<ILayoutIgnorer> ignoreList;

		private static readonly Vector2 center;

		public ConstraintMode AngleConstraint
		{
			get
			{
				return default(ConstraintMode);
			}
			set
			{
			}
		}

		public ConstraintMode RadiusConstraint
		{
			get
			{
				return default(ConstraintMode);
			}
			set
			{
			}
		}

		public Direction LayoutDir
		{
			get
			{
				return default(Direction);
			}
			set
			{
			}
		}

		public float RadiusStart
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float RadiusDelta
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float RadiusRange
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float AngleDelta
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float AngleStart
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float AngleCenter
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float AngleRange
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool ChildRotate
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override void CalculateLayoutInputVertical()
		{
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

		private void CalculateChildrenPositions()
		{
		}

		private void EnsureParameters(int childCount)
		{
		}

		private void EnsureAngleParameters(int childCount)
		{
		}

		private void EnsureRadiusParameters(int childCount)
		{
		}

		private void ProcessOneChild(RectTransform child, float angle, float radius)
		{
		}
	}
}
