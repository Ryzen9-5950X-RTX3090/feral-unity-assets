using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_RotateSpinSin : MonoBehaviour
	{
		[Tooltip("In which axis object should rotate")]
		public Vector3 RotationAxis;

		[Tooltip("How far can go rotation")]
		public float RotationRange;

		[Tooltip("How fast object should rotate to it's ranges")]
		public float SinSpeed;

		private float time;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
