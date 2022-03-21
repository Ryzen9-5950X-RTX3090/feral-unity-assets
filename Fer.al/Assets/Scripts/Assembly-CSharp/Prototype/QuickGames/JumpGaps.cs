using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class JumpGaps : QuickGamesBase
	{
		private class FailZone : MonoBehaviour
		{
			public JumpGaps Game;

			private void OnTriggerEnter2D(Collider2D collision)
			{
			}
		}

		[Header("JumpGaps")]
		public Rigidbody2D plank;

		public Transform ball;

		public GameObject failZone;

		public Transform midFrame;

		public float ballStartPositionX;

		public float plankStartPositionX;

		public float gapWidth;

		public float plankSpacing;

		public float plankSpeed;

		public float plankCycles;

		public float jumpForce;

		public float ballGravity;

		public int numStartingPlanks;

		private bool _isJumping;

		private int _plankSiblingIndex;

		private Vector3 _positionHolder;

		private Vector2 _jumpForce;

		private Vector2 _plankVelocity;

		private Rigidbody2D _ballRB;

		private List<Rigidbody2D> _planks;

		private FailZone _failZone;

		public override void MStart()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		private void MakePlank()
		{
		}

		private void MissedJump()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__26))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
