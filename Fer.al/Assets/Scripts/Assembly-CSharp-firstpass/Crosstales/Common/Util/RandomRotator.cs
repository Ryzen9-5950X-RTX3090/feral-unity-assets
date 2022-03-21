using UnityEngine;

namespace Crosstales.Common.Util
{
	public class RandomRotator : MonoBehaviour
	{
		[Tooltip("Use intervals to change the rotation (default: true).")]
		public bool UseInterval;

		[Tooltip("Random change interval between min (= x) and max (= y) in seconds (default: x = 10, y = 20).")]
		public Vector2 ChangeInterval;

		[Tooltip("Minimum rotation speed per axis (default: 5 for all axis).")]
		public Vector3 SpeedMin;

		[Tooltip("Minimum rotation speed per axis (default: 15 for all axis).")]
		public Vector3 SpeedMax;

		[Tooltip("Set the object to a random rotation at Start (default: false).")]
		public bool RandomRotationAtStart;

		private Transform tf;

		private Vector3 speed;

		private float elapsedTime;

		private float changeTime;

		public void Start()
		{
		}

		public void Update()
		{
		}
	}
}
