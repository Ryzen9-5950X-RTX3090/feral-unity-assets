using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_SlideObjectTo : MonoBehaviour
	{
		public FEasing.EFease EaseFunction;

		[Tooltip("How long in seconds should be transition")]
		public float Duration;

		[Tooltip("Offset for target position in local space")]
		public Vector3 OffsetPosition;

		[Tooltip("Offset for target rotation in local space")]
		public Vector3 OffsetRotation;

		protected bool goToTarget;

		protected float time;

		protected Vector3 initPos;

		protected Quaternion initRot;

		protected FEasing.Function func;

		private void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void ToggleMove()
		{
		}

		public void MoveToTarget()
		{
		}

		public void MoveBack()
		{
		}
	}
}
