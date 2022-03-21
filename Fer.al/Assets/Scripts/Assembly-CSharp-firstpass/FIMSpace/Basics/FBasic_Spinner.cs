using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_Spinner : FBasic_Rotator
	{
		[Tooltip("How quick spinning should slow down")]
		public float DeceleratePower;

		private void Start()
		{
		}

		protected override void Update()
		{
		}

		public void Spin(float power = 500f)
		{
		}
	}
}
