using TMPro;
using UnityEngine;

public class Match3UI_AvailablePuzzlePieceCount : MonoBehaviour
{
	[SerializeField]
	private GameObject _content;

	[SerializeField]
	[Tooltip("Leave as -1 for a full count")]
	private int _puzzleIndex;

	[SerializeField]
	private WWTextMeshProUGUI _countText;

	private int _count;

	private Match3AchievementRewardController RewardController
	{
		get
		{
			return null;
		}
	}

	public void OnAvailabilityStateChange(int inPuzzleIndex, int inPieceIndex)
	{
	}

	public void OnPuzzlePieceRedeemed(int inPuzzleIndex, int inPieceIndex)
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateCount()
	{
	}

	private void UpdateVisuals()
	{
	}
}
