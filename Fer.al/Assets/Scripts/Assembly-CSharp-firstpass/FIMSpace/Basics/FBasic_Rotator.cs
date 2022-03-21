using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_Rotator : MonoBehaviour
	{
		public Vector3 RotationAxis;

		public float RotationSpeed;

		public bool UnscaledDeltaTime;

		protected virtual void Update()
		{
		}
	}
}
