using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Parlor_Game
{
	public class DiceManager : ManagedBehaviour
	{
		[Header("Dice Manager")]
		public Dice[] dice;

		[Tooltip("Entry 0 will be player. Add more for opponent")]
		public Transform[] spawnLocations;

		public GameObject shuffleContainerPlayer;

		public GameObject shuffleContainerOpponent;

		[Tooltip("How far away the dice will spawn from the spawnLocations.")]
		public float spawnOffset;

		public float shootMagnitude;

		public float shootHeightForce;

		public float rollWaitTime;

		[Tooltip("Used for delay before rolling first die, and how long the die need to be at rest before reporting the roll is complete.")]
		public float rollDelay;

		public float diceScale;

		public float diceShuffleSpeed;

		public float diceResetTime;

		internal Dice selectedDice;

		internal List<Dice[]> diceHolder;

		private Vector3 _offset;

		private float _offsetDegrees;

		private bool _shufflingDice;

		public float setDiceBumpHeight;

		internal void SpawnDice()
		{
		}

		private void Chq(Dice die)
		{
		}

		[IteratorStateMachine(typeof(<ShuffleDice>d__19))]
		private IEnumerator ShuffleDice()
		{
			return null;
		}

		private void DiceCollision(bool inIgnore)
		{
		}

		private void ShuffleContainersToggle(bool inOn)
		{
		}

		[IteratorStateMachine(typeof(<RollDice>d__22))]
		internal IEnumerator RollDice()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ResetDice>d__23))]
		internal IEnumerator ResetDice()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<PickNew>d__24))]
		internal IEnumerator PickNew(Dice inDice)
		{
			return null;
		}
	}
}
