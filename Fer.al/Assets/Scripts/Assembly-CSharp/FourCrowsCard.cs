using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FourCrowsCard : MonoBehaviour
{
	internal enum EMoveType
	{
		Deal,
		Collect,
		DealerPlay
	}

	internal enum ECardType
	{
		Positive2,
		Positive1,
		Negative1,
		Negative2,
		Skip,
		Reset
	}

	public Renderer cardRenderer;

	public Texture[] cardFaces;

	public Vector3 playerPositionsRotation;

	public Vector3 dealerPositionsRotation;

	public Vector3 dealerPlaysRotation;

	internal ECardType cardType;

	internal bool hasBeenDealt;

	internal bool hasBeenPlayed;

	internal bool canDrop;

	internal int cardValue;

	internal bool canSelect;

	private FourCrowsGame _game;

	private FourCrowsDeckManager _deckManager;

	internal void SetCardFace()
	{
	}

	internal void InitCard(ECardType inCardType)
	{
	}

	private void OnMouseDown()
	{
	}

	private void OnMouseUp()
	{
	}

	[IteratorStateMachine(typeof(<MoveCard>d__19))]
	internal IEnumerator MoveCard(bool inPlayerCard, float inDelay, Transform inParent, EMoveType inMoveType)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DealerFlip>d__20))]
	internal IEnumerator DealerFlip()
	{
		return null;
	}

	internal void Return()
	{
	}
}
