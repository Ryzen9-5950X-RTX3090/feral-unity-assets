using UnityEngine;

namespace Gaia
{
	public class CameraController : MonoBehaviour
	{
		public GameObject target;

		public float targetHeight;

		public float distance;

		public float offsetFromWall;

		public float maxDistance;

		public float minDistance;

		public float xSpeed;

		public float ySpeed;

		public float yMinLimit;

		public float yMaxLimit;

		public float zoomRate;

		public float rotationDampening;

		public float zoomDampening;

		public LayerMask collisionLayers;

		public bool lockToRearOfTarget;

		public bool allowMouseInputX;

		public bool allowMouseInputY;

		private float xDeg;

		private float yDeg;

		private float currentDistance;

		private float desiredDistance;

		private float correctedDistance;

		private bool rotateBehind;

		private bool mouseSideButton;

		private float pbuffer;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void RotateBehindTarget()
		{
		}

		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}
	}
}
