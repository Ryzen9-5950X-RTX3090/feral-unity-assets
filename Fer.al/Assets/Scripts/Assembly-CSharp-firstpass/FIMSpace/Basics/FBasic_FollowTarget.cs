using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_FollowTarget : MonoBehaviour
	{
		[Tooltip("Multiplies deltaTime")]
		[Range(1f, 60f)]
		public float MoveSpeed;

		public Transform TargetTransform;

		public Vector3 PositionOffsetInTargetSpace;

		public EFUpdateClock UpdateClock;

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Follow()
		{
		}
	}
}
