using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Cinder_Encounter.Tug_Of_War
{
	public class TargetInRange : TugOfWar
	{
		[Header("Target In Range")]
		public RectTransform hUDTarget;

		public float targetMoveRange;

		public float targetMoveTimeMin;

		public float targetMoveTimeMax;

		public float targetNewPosMin;

		public float targetNewPosMax;

		public RectTransform hUDZone;

		public Rigidbody2D hUDZoneRB;

		public float zoneMoveRange;

		public float zoneClickPower;

		private float _currentTargetMoveTime;

		private float _targetMoveTime;

		private float _currentTargetPos;

		private Vector2 _targetPosStart;

		private Vector2 _targetPosEnd;

		private Vector2 _zonePos;

		internal override void OptionSelected(int inIdx)
		{
		}

		[IteratorStateMachine(typeof(<AtStartPoint>d__17))]
		protected override IEnumerator AtStartPoint()
		{
			return null;
		}

		protected override void ChallengeUpdate()
		{
		}

		protected override void ProgressUpdate()
		{
		}

		protected override void ChallengeOver()
		{
		}
	}
}
