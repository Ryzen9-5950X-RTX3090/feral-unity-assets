using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Parlor_Game.DiceTest
{
	public class DiceTest : ParlorGame
	{
		[Header("Dice")]
		public Transform diceLocator;

		public GameObject die;

		private List<GameObject> dice;

		private int numDice;

		private List<int> countedDice;

		private bool allDiceCounted;

		public override void MStart()
		{
		}

		private void ResetGame(bool newGame)
		{
		}

		public override void MUpdate()
		{
		}

		internal override void Intro()
		{
		}

		[IteratorStateMachine(typeof(<RollDice>d__10))]
		private IEnumerator RollDice()
		{
			return null;
		}

		private void Shoot(GameObject d)
		{
		}

		private int GetDieValue(GameObject dieObject)
		{
			return default(int);
		}

		internal override void ResultsDone()
		{
		}
	}
}
