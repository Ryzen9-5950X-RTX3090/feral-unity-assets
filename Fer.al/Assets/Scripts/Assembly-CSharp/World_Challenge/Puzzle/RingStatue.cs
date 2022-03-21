using UnityEngine;

namespace World_Challenge.Puzzle
{
	public class RingStatue : WorldPuzzle
	{
		public Color onColor;

		public Color offColor;

		private GameObject baseRing;

		private GameObject bottomRing;

		private GameObject middleRing;

		private GameObject topRing;

		private float rotationIncrement;

		private float targetRotation;

		internal override void InitializePuzzle()
		{
		}

		internal void Rotate(GameObject ring, int direction)
		{
		}

		public void LeftControlClicked(int ringIndex)
		{
		}

		public void RightControlClicked(int ringIndex)
		{
		}

		public void ExitClicked()
		{
		}

		private GameObject GetRingByIndex(int ringIndex)
		{
			return null;
		}

		private void CheckState()
		{
		}

		private void UpdateColor(GameObject ring, bool state)
		{
		}
	}
}
