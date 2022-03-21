using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QueensDuelDiceManager : MonoBehaviour
{
	[Serializable]
	public struct DiceBoardColumn
	{
		public string columnName;

		public int _columnScore;

		public QueensDuelDiceSpot[] Row;

		public int columnScore
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
	}

	public float diePickupTime;

	public float validSpotDistance;

	public float moveHeightY;

	public QueensDuelDice dicePrefab;

	public Transform[] playerDiceLocators;

	public Transform[] playerTieDiceLocators;

	public DiceBoardColumn[] playerPlacementLocators;

	public Transform[] opponentDiceLocators;

	public Transform[] opponentTieDiceLocators;

	public DiceBoardColumn[] opponentPlacementLocators;

	internal QueensDuelDice[] playerDice;

	internal QueensDuelDice[] opponentDice;

	internal QueensDuelDice[] allDice;

	internal QueensDuelDice[] playerTieDice;

	internal QueensDuelDice[] opponentTieDice;

	internal QueensDuelDice[] allTieDice;

	internal bool Shaking;

	internal int numDiceRolling;

	internal QueensDuelDice selectedDice;

	private Vector3 _diceMover;

	private int _numPlayerDiceRolling;

	private QueensDuelGame _game;

	public float distFromKeepSpotToKeep;

	private void Start()
	{
	}

	internal void DiceFinishedRolling()
	{
	}

	internal void RequestRollValues(string inDiceRequest, string inTurnNumber)
	{
	}

	internal void ReceiveRollValues(string inRollResults)
	{
	}

	[IteratorStateMachine(typeof(<StartShake>d__28))]
	internal IEnumerator StartShake()
	{
		return null;
	}

	internal void PlayDiceDrop()
	{
	}

	[IteratorStateMachine(typeof(<StartTieShake>d__30))]
	internal IEnumerator StartTieShake()
	{
		return null;
	}

	internal void UnlockAll()
	{
	}

	internal void Roll()
	{
	}

	private void SpotIndicatorChq(int inPlacemantLocatorIndex, int inRow, bool inActive)
	{
	}

	internal void PickupDie(QueensDuelDice inDie)
	{
	}

	[IteratorStateMachine(typeof(<MoveDie>d__35))]
	private IEnumerator MoveDie(Transform inTrans, Vector3 inEndPosition)
	{
		return null;
	}

	internal void UpdateHighlightedSpots()
	{
	}

	internal void SelectedDice(QueensDuelDice inDice)
	{
	}

	private bool AllPlaced()
	{
		return default(bool);
	}

	private void SpotChq(int inPlacmentLocatorIndex, int inRowIndex)
	{
	}

	private void ValidSpotChq()
	{
	}

	private bool CloseToSpotChq(int inPlacmentLocatorIndex, int inRowIndex)
	{
		return default(bool);
	}

	private bool CloseToSpotPosition(Transform inTrans1, Transform inTrans2)
	{
		return default(bool);
	}

	internal void PlayerMoveDice(Vector3 inPoint)
	{
	}

	internal void HideUnplayedDice()
	{
	}

	internal void SpawnTieDice(List<int> inTieColumns)
	{
	}

	internal void Replay()
	{
	}

	internal void Init()
	{
	}

	[IteratorStateMachine(typeof(<AutoFinalRoll>d__48))]
	internal IEnumerator AutoFinalRoll()
	{
		return null;
	}

	internal void Unload()
	{
	}
}
