using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Cinder_Encounter.Tug_Of_War
{
	public class TugOfWar : WorldChallenge
	{
		[Header("Tug of War")]
		public LineRenderer theRope;

		public Transform playerRopeEnd;

		public Transform cinderRopeEnd;

		public RectTransform hUDProgress;

		public float progressFullSize;

		public float progressTimeScaler;

		public float worldMoveRange;

		protected float progressScaler;

		private Vector2 _progressSize;

		private float _currentWorldMove;

		private Transform _cinderMouth;

		private Transform _playerMouth;

		private Vector3 _cinderWinPos;

		private Vector3 _cinderLosePos;

		private Vector3 _playerWinPos;

		private Vector3 _playerLosePos;

		public override void MStart()
		{
		}

		internal override void OptionSelected(int inIdx)
		{
		}

		private Transform FindName(Transform inParent, string inName)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<AtStartPoint>d__19))]
		protected override IEnumerator AtStartPoint()
		{
			return null;
		}

		protected override void ChallengeUpdate()
		{
		}

		protected override void ChallengeOver()
		{
		}

		protected virtual void ProgressUpdate()
		{
		}

		protected override void CloseChallenge()
		{
		}

		internal override void StartGame()
		{
		}
	}
}
