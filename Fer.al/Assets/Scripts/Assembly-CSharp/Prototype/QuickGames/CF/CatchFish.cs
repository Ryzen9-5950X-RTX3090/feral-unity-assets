using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames.CF
{
	public class CatchFish : QuickGamesBase
	{
		[Header("Catch Fish")]
		public Transform aimer;

		public List<Transform> targets;

		public Transform startPoint;

		public LineRenderer line;

		public float rotateSpeed;

		public float rotateRange;

		public float fadeTime;

		public float lineSpeed;

		public int lineVerts;

		[Header("Intro")]
		public float timeForIntro;

		private bool _launched;

		private float _minAngle;

		private float _maxAngle;

		private float[] _targetAngles;

		private int _hitTargetIndex;

		private int _rotateDir;

		private List<Vector3> _pointList;

		private List<Vector3> _lineList;

		private Transform[] _targets;

		private Transform _hitTarget;

		private Vector3 _midPoint;

		public override void MStart()
		{
		}

		private void RotateAimer()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__24))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ShowResults>d__25))]
		public override IEnumerator ShowResults()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<FadeTarget>d__26))]
		private IEnumerator FadeTarget(int inTargetIndex)
		{
			return null;
		}
	}
}
