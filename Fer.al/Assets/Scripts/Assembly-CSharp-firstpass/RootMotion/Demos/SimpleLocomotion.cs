using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		public enum RotationMode
		{
			Smooth,
			Linear
		}

		[SerializeField]
		[Tooltip("The component that updates the camera.")]
		private CameraController cameraController;

		[SerializeField]
		[Tooltip("Acceleration of movement.")]
		private float accelerationTime;

		[SerializeField]
		[Tooltip("Turning speed.")]
		private float turnTime;

		[SerializeField]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		private bool walkByDefault;

		[SerializeField]
		[Tooltip("Smooth or linear rotation.")]
		private RotationMode rotationMode;

		[SerializeField]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		private float moveSpeed;

		private Animator animator;

		private float speed;

		private float angleVel;

		private float speedVel;

		private Vector3 linearTargetDirection;

		private CharacterController characterController;

		public bool isGrounded
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void Rotate()
		{
		}

		private void Move()
		{
		}

		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}
	}
}
