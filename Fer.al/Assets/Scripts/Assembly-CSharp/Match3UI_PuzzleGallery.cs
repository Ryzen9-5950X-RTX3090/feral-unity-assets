using System.Collections.Generic;
using UnityEngine;

public class Match3UI_PuzzleGallery : MonoBehaviour
{
	[SerializeField]
	private Match3UI_AchievementItem _achievementItemPrefab;

	[SerializeField]
	private Transform _achievementItemParent;

	[SerializeField]
	private Match3UI_PuzzleImage _puzzleImage;

	[SerializeField]
	[Header("Puzzle Piece Redemption Visuals")]
	private Transform _pieceTargetParent;

	[SerializeField]
	private Transform _pieceFxPrefab;

	private List<Transform> _pieceTargets;

	private Match3AchievementPuzzle _currentPuzzle;

	private int _puzzleIndex;

	private List<Match3UI_AchievementItem> _achievementItems;

	private Match3AchievementRewardController RewardController
	{
		get
		{
			return null;
		}
	}

	private List<Transform> PieceTargets
	{
		get
		{
			return null;
		}
	}

	public void Show(Match3AchievementPuzzle inPuzzle, int inPuzzleIndex)
	{
	}

	public void Hide()
	{
	}

	public void BtnClicked_Back()
	{
	}

	public void OnPuzzlePieceRedeem(int inPuzzleIndex, int inPieceIndex)
	{
	}

	private void Setup(Match3AchievementPuzzle inPuzzle, int inPuzzleIndex)
	{
	}

	private void CheckForPendingPrize()
	{
	}
}
