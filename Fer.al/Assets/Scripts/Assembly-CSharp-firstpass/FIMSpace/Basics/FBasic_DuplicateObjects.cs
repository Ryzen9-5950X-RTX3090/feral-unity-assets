using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_DuplicateObjects : MonoBehaviour
	{
		public enum FEDuplicateDirection
		{
			GoIterative,
			GoFromCenter
		}

		public enum FEDuplicateOrigin
		{
			FromToDuplicate,
			FromComponent
		}

		[Tooltip("Put here object which you want duplicate")]
		public GameObject ToDuplicate;

		[Tooltip("How many copies in which axis")]
		public Vector3 DuplicatesCount;

		[Tooltip("How far from each other should be created copies")]
		public Vector3 Offsets;

		[Tooltip("If you want raycast from up and put objects for example on terrain")]
		public bool PlaceOnGround;

		public FEDuplicateDirection DuplicationType;

		public FEDuplicateOrigin DuplicationOrigin;

		public void Duplicate()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
