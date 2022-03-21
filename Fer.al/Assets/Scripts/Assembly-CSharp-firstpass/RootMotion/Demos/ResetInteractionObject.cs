using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.Demos
{
	public class ResetInteractionObject : MonoBehaviour
	{
		public float resetDelay;

		private Vector3 defaultPosition;

		private Quaternion defaultRotation;

		private Transform defaultParent;

		private Rigidbody r;

		private void Start()
		{
		}

		private void OnPickUp(Transform t)
		{
		}

		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}
	}
}
