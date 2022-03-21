using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_PowerUpObject : MonoBehaviour
	{
		[Header("Variables to controll animation of power up")]
		public float YFloatingValue;

		public float FloatingSpeedRate;

		public float RotationSpeed;

		[Header("If collision is detected with object of given tag, power up will be collected")]
		public string TagToCollideWith;

		private Vector3 initPosition;

		private float randomOffset;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		protected void Collect()
		{
		}
	}
}
