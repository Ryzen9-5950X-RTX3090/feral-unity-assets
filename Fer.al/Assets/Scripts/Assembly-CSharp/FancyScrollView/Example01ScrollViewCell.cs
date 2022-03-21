using UnityEngine;
using UnityEngine.UI;

namespace FancyScrollView
{
	public class Example01ScrollViewCell : FancyScrollViewCell<Example01CellDto>
	{
		[SerializeField]
		private Animator animator;

		[SerializeField]
		private Text message;

		private static readonly int scrollTriggerHash;

		private float currentPosition;

		public override void UpdateContent(Example01CellDto itemData)
		{
		}

		public override void UpdatePosition(float position)
		{
		}

		private void OnEnable()
		{
		}
	}
}
