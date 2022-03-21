using System.Runtime.CompilerServices;
using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_ObjectVibrate : MonoBehaviour
	{
		[Tooltip("How fast object should change translation directions")]
		public float VibrationRate;

		[Tooltip("How far object can go from it's initial local position")]
		public float BaseRange;

		[Tooltip("Smoothing motion for object")]
		[Range(0f, 1f)]
		public float SmoothTranslation;

		private float[] randomOffsets;

		private float time;

		private float speed;

		private float range;

		internal float intensity;

		public Vector3 AxesMultiplier;

		public bool ChangeObjectPosition;

		public Vector3 initialPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 localPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
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

		public void ChooseNewSeed()
		{
		}
	}
}
