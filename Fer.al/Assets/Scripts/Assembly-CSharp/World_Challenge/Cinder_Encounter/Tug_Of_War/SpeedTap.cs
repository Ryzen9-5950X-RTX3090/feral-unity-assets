using UnityEngine;

namespace World_Challenge.Cinder_Encounter.Tug_Of_War
{
	public class SpeedTap : TugOfWar
	{
		[Header("Speed Tap")]
		public float timeAddedPerTap;

		private float _currentTime;

		protected override void ChallengeUpdate()
		{
		}

		protected override void ProgressUpdate()
		{
		}
	}
}
