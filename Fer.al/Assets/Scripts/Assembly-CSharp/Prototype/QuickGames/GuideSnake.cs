using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class GuideSnake : QuickGamesBase
	{
		private class SnakeMover : MonoBehaviour
		{
			internal GuideSnake Game;

			internal Vector3 moveTo;

			internal Vector3 scale;

			internal int movePositionIndex;

			internal bool isHead;

			internal RawImage image;

			private void Awake()
			{
			}

			[IteratorStateMachine(typeof(<RotateEyes>d__7))]
			private IEnumerator RotateEyes(float inAngle)
			{
				return null;
			}

			internal void Move()
			{
			}

			private void OnTriggerEnter2D(Collider2D collision)
			{
			}
		}

		[Header("Guide Snake")]
		public GameObject snakeHead;

		public GameObject snakeBodyPart;

		public GameObject target;

		public Transform snakeEyesRotator;

		public Transform ember;

		public float screenLimitX;

		public float screenLimitY;

		public int numSegments;

		public float snakeSpeed;

		public float timeBetweenSegments;

		public int tailLength;

		public int numEmbers;

		public float pulseTime;

		public float pulseScale;

		public float eyeRotateSpeed;

		public float placementBuffer;

		[Header("Intro")]
		public float timeForIntro;

		private int _bodyPartsSiblingIndex;

		private Vector2 _moveDir;

		private List<SnakeMover> _allParts;

		private float _minMoveDist;

		private List<Vector2> _movePositions;

		private List<Vector3> _placedPositions;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__25))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		private void FixedUpdate()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		private void MakeBodyPart()
		{
		}

		private Vector3 GetPlacmentPos(bool inFirst, int inTries)
		{
			return default(Vector3);
		}

		private void GetNextMovePosition()
		{
		}

		private void MoveParts()
		{
		}

		private void OutOfBounds()
		{
		}

		[IteratorStateMachine(typeof(<PlaceObjects>d__33))]
		private IEnumerator PlaceObjects()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ScalePart>d__34))]
		private IEnumerator ScalePart(SnakeMover inSM)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ColorPart>d__35))]
		private IEnumerator ColorPart(SnakeMover inSM)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<HitTarget>d__36))]
		private IEnumerator HitTarget(Collider2D inCollider)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ScaleAll>d__37))]
		private IEnumerator ScaleAll()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ShowResults>d__38))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
