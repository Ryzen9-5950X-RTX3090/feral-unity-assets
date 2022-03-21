using System;

namespace UnityEngine.UI
{
	[Serializable]
	public class PooledLayoutElement
	{
		public RectTransform rectTransform;

		public bool ignoreLayout;

		public float minWidth;

		public float minHeight;

		public float preferredWidth;

		public float preferredHeight;

		public float flexibleWidth;

		public float flexibleHeight;

		public int layoutPriority;

		public Vector2 actualSize;

		public Vector2 actualPos;
	}
}
