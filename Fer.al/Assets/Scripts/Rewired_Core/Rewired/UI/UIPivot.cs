using UnityEngine;

namespace Rewired.UI
{
	public struct UIPivot
	{
		public float min;

		public float max;

		public static UIPivot TopLeft
		{
			get
			{
				return default(UIPivot);
			}
		}

		public static UIPivot TopCenter
		{
			get
			{
				return default(UIPivot);
			}
		}

		public static UIPivot TopRight
		{
			get
			{
				return default(UIPivot);
			}
		}

		public static UIPivot MiddleLeft
		{
			get
			{
				return default(UIPivot);
			}
		}

		public static UIPivot MiddleCenter
		{
			get
			{
				return default(UIPivot);
			}
		}

		public static UIPivot MiddleRight
		{
			get
			{
				return default(UIPivot);
			}
		}

		public static UIPivot BottomLeft
		{
			get
			{
				return default(UIPivot);
			}
		}

		public static UIPivot BottomCenter
		{
			get
			{
				return default(UIPivot);
			}
		}

		public static UIPivot BottomRight
		{
			get
			{
				return default(UIPivot);
			}
		}

		public UIPivot(float min, float max)
		{
		}

		public static implicit operator Vector2(UIPivot x)
		{
			return default(Vector2);
		}

		public static implicit operator UIPivot(Vector2 x)
		{
			return default(UIPivot);
		}
	}
}
