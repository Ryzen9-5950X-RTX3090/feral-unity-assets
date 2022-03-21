using UnityEngine;
using UnityEngine.UI;

namespace FancyScrollView
{
	public class Example03ScrollViewCell : FancyScrollViewCell<Example03CellDto, Example03ScrollViewContext>
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

		public override void UpdateContent(Example03CellDto itemData)
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
