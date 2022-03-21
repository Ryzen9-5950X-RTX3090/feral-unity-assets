using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_HoldPosition : MonoBehaviour
	{
		[Tooltip("Multiplies deltaTime")]
		public float HoldPower;

		public bool ResetRigidbodyVelocity;

		protected Vector3 initialPosition;

		protected Rigidbody rigidbodyToHold;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}
	}
}
