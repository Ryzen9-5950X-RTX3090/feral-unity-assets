using UnityAtoms;
using UnityEngine;

public class Match3AchievementRewardController : MonoBehaviour
{
	[SerializeField]
	private CachedUserVar _puzzleRedemptionStatusUserVar;

	[SerializeField]
	private CachedUserVar _puzzlePieceRedemptionStatusUserVar;

	[SerializeField]
	private IntIntEvent _puzzlePieceRedeemedEvent;

	[SerializeField]
	private IntEvent _puzzleRedeemedEvent;

	[SerializeField]
	private Match3PuzzleCollectionVariable _puzzleCollection;

	private const int PUZZLE_PRIZE_LIST_INDEX = 1;

	public int GetAvailablePuzzlePieces(int inPuzzleIndex = -1)
	{
		return default(int);
	}

	public bool GetPuzzleRedemptionStatus(int inPuzzleIndex)
	{
		return default(bool);
	}

	public bool GetPuzzlePieceRedemptionStatus(int inPuzzleIndex, int inPieceIndex)
	{
		return default(bool);
	}

	public void RedeemPuzzlePiece(int inPuzzleIndex, int inPieceIndex)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void RedeemPuzzle(int inPuzzleIndex)
	{
	}

	private void OnMinigamePrizeGiven(MinigamePrizeGiven inMessage)
	{
	}
}
