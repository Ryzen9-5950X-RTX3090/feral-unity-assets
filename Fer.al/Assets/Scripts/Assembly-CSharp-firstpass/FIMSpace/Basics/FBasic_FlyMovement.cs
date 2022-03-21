using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_FlyMovement : MonoBehaviour
	{
		[Tooltip("How quick model should fly on it's trajectory")]
		public float MainSpeed;

		[Tooltip("How far should fly our object")]
		public Vector3 RangeValue;

		[Tooltip("Multiplier for range value but applied to all axes")]
		public float RangeMul;

		[Tooltip("Additional translation on y axis if you want movement to be little like butterfly flight")]
		public float AddYSin;

		public float AddYSinTimeSpeed;

		[Tooltip("How quick object should rotate to it's forward movement direction")]
		public float RotateForwardSpeed;

		private float time;

		private Vector3 offset;

		private Vector3 initPos;

		private Vector3 preOffsetNoYAdd;

		private Vector3 posOffsetNoYAdd;

		private Vector3 speeds;

		private Vector3 randomVector1;

		private Vector3 randomVector2;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
