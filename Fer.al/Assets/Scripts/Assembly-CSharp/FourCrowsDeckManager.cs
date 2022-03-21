using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FourCrowsDeckManager : MonoBehaviour
{
	public int numCardsPerPlayer;

	public float dealMoveTime;

	[Tooltip("The time between each card being dealt out")]
	public float dealDelay;

	public float dealerPlayTime;

	public float dealerFlipTime;

	public float cardCompareTime;

	public FourCrowsCard cardPrefab;

	public Transform dealPosition;

	public Transform[] playerHandPositions;

	public Transform[] dealerHandPositions;

	public Transform[] playerPlayPositions;

	public Transform[] dealerPlayPositions;

	public float validSpotDistance;

	public float cardDropTime;

	public float rotateTime;

	public float dealerFlipRiseHeight;

	internal int numCardsPositive2;

	internal int numCardsPositive1;

	internal int numCardsNegative1;

	internal int numCardsNegative2;

	internal int numCardsSkip;

	internal Renderer[] playerPlayIndictors;

	internal FourCrowsCard[] allDeckCards;

	private FourCrowsCard _selectedCard;

	private int _numCardsInMotion;

	private Vector3 _cardMover;

	private FourCrowsGame _game;

	internal FourCrowsCard SelectedCard
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	internal void DealCardsResponse(ParlorGameCommand parlorGameCommand)
	{
	}

	internal void PickupCard(FourCrowsCard inCard)
	{
	}

	[IteratorStateMachine(typeof(<MoveCard>d__33))]
	private IEnumerator MoveCard(Transform inTrans, Vector3 inEndPosition, bool inUseLocal)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<RotateCard>d__34))]
	private IEnumerator RotateCard(Transform inTrans, Vector3 inEndRotation)
	{
		return null;
	}

	internal void DropCard()
	{
	}

	internal void Init()
	{
	}

	internal void CardMoved()
	{
	}

	private FourCrowsCard DealCard(bool inPlayerCard, int inDeckIndex, int inHandIndex, float inDelay)
	{
		return null;
	}

	internal void ReturnCard(FourCrowsCard inCard)
	{
	}

	[IteratorStateMachine(typeof(<CollectDeck>d__40))]
	internal IEnumerator CollectDeck()
	{
		return null;
	}

	private bool CloseToSpotPosition(Transform inTrans1, Transform inTrans2)
	{
		return default(bool);
	}

	internal void PlayerMoveCard(Vector3 inPoint)
	{
	}

	private void ValidSpotChq()
	{
	}

	private List<FourCrowsCard> InitSuit(int inNumCard, FourCrowsCard.ECardType inCardType)
	{
		return null;
	}

	internal void Cleanup()
	{
	}

	internal void ResetCardIndicators()
	{
	}
}
