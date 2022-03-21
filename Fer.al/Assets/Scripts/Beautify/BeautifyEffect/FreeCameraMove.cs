using UnityEngine;

namespace BeautifyEffect
{
	public class FreeCameraMove : MonoBehaviour
	{
		public float cameraSensitivity;

		public float climbSpeed;

		public float normalMoveSpeed;

		public float slowMoveFactor;

		public float fastMoveFactor;

		private float rotationX;

		private float rotationY;

		private Quaternion originalRotation;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
