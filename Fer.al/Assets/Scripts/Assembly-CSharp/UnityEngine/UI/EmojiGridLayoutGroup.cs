using System;

namespace UnityEngine.UI
{
	[AddComponentMenu("Layout/EmojiGrid Layout Group", 153)]
	public class EmojiGridLayoutGroup : GridLayoutGroup
	{
		[SerializeField]
		private RectTransform _heightLimiter;

		[SerializeField]
		private float _maxRows;

		private bool _exceedsBounds;

		public Action OnWidthCalculated;

		public bool ExceedsBounds
		{
			get
			{
				return default(bool);
			}
		}

		public override void CalculateLayoutInputHorizontal()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}
	}
}
