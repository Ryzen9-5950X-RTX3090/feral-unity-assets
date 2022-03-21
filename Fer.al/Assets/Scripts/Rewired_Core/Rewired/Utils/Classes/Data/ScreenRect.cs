using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public struct ScreenRect
	{
		public float xMin;

		public float yMin;

		public float width;

		public float height;

		public float xMax
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float yMax
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Vector2 center
		{
			get
			{
				return default(Vector2);
			}
		}

		public ScreenRect(float left, float bottom, float width, float height)
		{
		}

		public static implicit operator Rect(ScreenRect o)
		{
			return default(Rect);
		}

		public static implicit operator ScreenRect(Rect o)
		{
			return default(ScreenRect);
		}
	}
}
