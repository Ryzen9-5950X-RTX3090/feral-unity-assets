using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Parlor_Game.Dice_Versus
{
	public class DiceVersus : ParlorGame
	{
		[Header("Dice Versus")]
		public DiceManager diceManager;

		public Renderer partitionRenderer;

		public Transform[] slotsPlayer;

		public Transform[] slotsOpponent;

		public MeshRenderer[] slotIndicatorMeshes;

		public float diceMoveMaxX;

		public float diceMoveMaxZ;

		public float partitionChangeTime;

		public float diceToLoseSpotTime;

		public float diceToSlotTime;

		private Dice[] _slotsDicePlayer;

		private Dice[] _slotsDiceOpponent;

		private Vector3 _selectedDicePos;

		private Vector3 _pointAlongPlane;

		private Ray _mouseScreenPointToRay;

		private Plane _touchPlane;

		private float _distanceToTouchPlane;

		private Dice _selectedDice;

		private List<Dice> _opponentsDice;

		private Color _partitionTransparent;

		private Color _partitionOpaque;

		private int closestSlot;

		private int _playerSlotsWon;

		public override void MStart()
		{
		}

		internal override void Intro()
		{
		}

		[IteratorStateMachine(typeof(<RollDice>d__25))]
		private IEnumerator RollDice()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<PartitionChange>d__26))]
		private IEnumerator PartitionChange(bool inHide)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<DiceToSlot>d__27))]
		private IEnumerator DiceToSlot(Dice inDie, Transform inSlot)
		{
			return null;
		}

		public override void MUpdate()
		{
		}

		[IteratorStateMachine(typeof(<DiceToLoseSpot>d__29))]
		private IEnumerator DiceToLoseSpot(Transform inDieTrans, Vector3 inEndPos)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<TallyScore>d__30))]
		private IEnumerator TallyScore()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ShowResults>d__31))]
		public override IEnumerator ShowResults()
		{
			return null;
		}

		internal override void ResultsDone()
		{
		}

		[IteratorStateMachine(typeof(<CleanupAndReset>d__33))]
		private IEnumerator CleanupAndReset()
		{
			return null;
		}
	}
}
