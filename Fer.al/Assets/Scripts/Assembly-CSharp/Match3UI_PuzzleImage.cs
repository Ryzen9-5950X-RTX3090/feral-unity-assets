using UnityEngine;
using UnityEngine.UI;

public class Match3UI_PuzzleImage : MonoBehaviour
{
	[SerializeField]
	private Image _puzzleGraphic;

	private Material _puzzleMat;

	private Match3AchievementPuzzle _puzzle;

	private float[] _puzzlePieceStates;

	private bool _isDirty;

	private int _puzzleIndex;

	private Match3AchievementRewardController RewardController
	{
		get
		{
			return null;
		}
	}

	public void Setup(Match3AchievementPuzzle inPuzzle, int inPuzzleIndex)
	{
	}

	public void AtomEvent_OnPuzzlePieceRedeemed(int inPuzzleIndex, int inPuzzlePieceIndex)
	{
	}

	private void RefreshAllPieces()
	{
	}

	private void Update()
	{
	}

	private void UpdateMaterial()
	{
	}
}
