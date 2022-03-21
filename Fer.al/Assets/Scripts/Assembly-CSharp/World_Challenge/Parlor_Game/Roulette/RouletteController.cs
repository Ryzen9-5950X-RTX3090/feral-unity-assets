using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Parlor_Game.Roulette
{
	public class RouletteController : ParlorGame
	{
		public GameObject wheelPrefab;

		public GameObject ballPrefab;

		private GameObject board;

		private GameObject wheel;

		private GameObject ball;

		private Rigidbody wheelBody;

		private Rigidbody ballBody;

		private Vector3 ballStartPos;

		private float spinUpTime;

		private float spinUpForce;

		private float spinFreeTime;

		private float spinDownTime;

		private float spinDownForce;

		private float elapsedStepTime;

		private bool stepComplete;

		private int currentStep;

		private int targetColorId;

		private int enteredColorId;

		public override void MStart()
		{
		}

		private void ResetGame(bool newGame)
		{
		}

		public override void MUpdate()
		{
		}

		public void BallEnteredColor(int colorId)
		{
		}

		internal override void Intro()
		{
		}

		private void DropBall()
		{
		}

		[IteratorStateMachine(typeof(<PerformSpinUp>d__24))]
		private IEnumerator PerformSpinUp()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<SpinUp>d__25))]
		private IEnumerator SpinUp()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<PerformSpinFree>d__26))]
		private IEnumerator PerformSpinFree()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<PerformSpinDown>d__27))]
		private IEnumerator PerformSpinDown()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<SpinDown>d__28))]
		private IEnumerator SpinDown()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<FinishGame>d__29))]
		private IEnumerator FinishGame()
		{
			return null;
		}

		internal override void ResultsDone()
		{
		}
	}
}
