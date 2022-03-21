using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Match3UI_AchievementItem : MonoBehaviour
{
	[SerializeField]
	[Header("CheckBox")]
	private Graphic _checkMarkBg;

	[SerializeField]
	private Color _bgColorIncomplete;

	[SerializeField]
	private Color _bgColorComplete;

	[SerializeField]
	private GameObject _checkMark;

	[SerializeField]
	private GameObject _puzzlePiece;

	[SerializeField]
	[Header("Text")]
	private WWTextMeshProUGUI _achievementText;

	[SerializeField]
	private Color _textColorIncomplete;

	[SerializeField]
	private Color _textColorComplete;

	private int _puzzleIndex;

	private int _puzzlePieceIndex;

	public Transform PuzzlePiece
	{
		get
		{
			return null;
		}
	}

	private Match3AchievementRewardController RewardController
	{
		get
		{
			return null;
		}
	}

	public void Setup(Match3Achievement inAchievement, int inPuzzleIndex, int inPuzzlePieceIndex)
	{
	}

	public void BtnClicked_RedeemPuzzlePiece()
	{
	}
}
