using UnityEngine;

namespace StrayTech
{
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Animator))]
	public class Character : MonoBehaviour
	{
		[SerializeField]
		private float _movingTurnSpeed;

		[SerializeField]
		private float _stationaryTurnSpeed;

		[SerializeField]
		private float _jumpPower;

		[SerializeField]
		[Range(1f, 4f)]
		private float _gravityMultiplier;

		[SerializeField]
		private float _runCycleLegOffset;

		[SerializeField]
		private float _moveSpeedMultiplier;

		[SerializeField]
		private float _animSpeedMultiplier;

		[SerializeField]
		private float _groundCheckDistance;

		private Rigidbody _rigidbody;

		private Animator _animator;

		private bool _isGrounded;

		private float _origGroundCheckDistance;

		private Vector3 _groundNormal;

		private float _turnAmount;

		private float _forwardAmount;

		private CapsuleCollider _capsule;

		private float _capsuleHeight;

		private Vector3 _capsuleCenter;

		private bool _crouching;

		private void Start()
		{
		}

		public void MoveThirdPerson(Vector3 move, bool crouch, bool jump)
		{
		}

		public void MoveFirstPerson(Vector3 move, bool crouch, bool jump)
		{
		}

		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		private void PreventStandingInLowHeadroom()
		{
		}

		private void UpdateAnimator(Vector3 move)
		{
		}

		private void HandleAirborneMovement()
		{
		}

		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		private void ApplyExtraTurnRotation()
		{
		}

		private void CheckGroundStatus()
		{
		}

		public void OnAnimatorMove()
		{
		}
	}
}
