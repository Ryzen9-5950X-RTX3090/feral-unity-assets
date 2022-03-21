using UnityEngine;
using UnityEngine.UI;

namespace FancyScrollView
{
	public class Example04ScrollViewCell : FancyScrollViewCell<Example04CellDto, Example04ScrollViewContext>
	{
		[SerializeField]
		private Text message;

		[SerializeField]
		private Image image;

		[SerializeField]
		private Button button;

		private float currentPosition;

		private void Start()
		{
		}

		public override void UpdateContent(Example04CellDto itemData)
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
