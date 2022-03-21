using TMPro;
using UnityEngine;

public class Match3UI_PuzzleItem : MonoBehaviour
{
	[SerializeField]
	private GameObject _unreadCountGroup;

	[SerializeField]
	private WWTextMeshProUGUI _unreadCountText;

	[SerializeField]
	private GameObject _completeGroup;

	[SerializeField]
	private Match3UI_PuzzleImage _puzzleImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	private Match3AchievementPuzzle _puzzle;

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

	public void BtnClicked_OpenPuzzle()
	{
	}
}
