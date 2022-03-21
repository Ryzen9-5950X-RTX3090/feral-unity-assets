using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace FancyScrollView
{
	public class FancyScrollViewCell_Temp : FancyScrollViewCell<int, FancyScrollViewContext_Temp>
	{
		[SerializeField]
		private WWTextMeshProUGUI _text;

		[SerializeField]
		private FeralButton _button;

		[SerializeField]
		private AnimationCurve _scaleAnimCurve;

		[SerializeField]
		private AnimationCurve _posAnimCurve;

		private int _itemData;

		private float currentPosition;

		public override bool IsSelectable
		{
			get
			{
				return default(bool);
			}
		}

		private void Start()
		{
		}

		public override void UpdateContent(int itemData)
		{
		}

		public override void UpdatePosition(float position)
		{
		}

		private void OnPressedCell()
		{
		}

		private void OnEnable()
		{
		}
	}
}
