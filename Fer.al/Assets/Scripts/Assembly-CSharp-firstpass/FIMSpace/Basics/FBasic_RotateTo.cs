using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_RotateTo : MonoBehaviour
	{
		public Vector3 TargetRotation;

		public float RotationSpeed;

		public bool UnscaledDeltaTime;

		public Transform TargetTransform;

		protected virtual void Update()
		{
		}
	}
}
