using UnityEngine;
using UnityEngine.UI;

namespace FancyScrollView
{
	public class Example02ScrollViewCell : FancyScrollViewCell<Example02CellDto, Example02ScrollViewContext>
	{
		[SerializeField]
		private Animator animator;

		[SerializeField]
		private Text message;

		[SerializeField]
		private Image image;

		[SerializeField]
		private Button button;

		private static readonly int scrollTriggerHash;

		private float currentPosition;

		private void Start()
		{
		}

		public override void UpdateContent(Example02CellDto itemData)
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
