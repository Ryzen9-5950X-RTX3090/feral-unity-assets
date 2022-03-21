using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Match3UI_ResultsScreen : MonoBehaviour
{
	public Match3UI_RewardItem rewardItem;

	public WWTextMeshProUGUI scoreText;

	public WWTextMeshProUGUI likesText;

	public WWTextMeshProUGUI levelText;

	public WWImage levelProgressFillbar;

	public WWTextMeshProUGUI gameResultsText;

	public WWTextMeshProUGUI gameProgressText;

	public GameObject gameResultsButtons;

	public GameObject gameProgressButtons;

	public GameObject purchaseRetryButton;

	private List<Match3UI_RewardItem> rewards;

	public void Show(int inLevel, float inLevelProgress, int inScore, IReadOnlyDictionary<Match3Reward, int> inRewards, bool isGameProgress = false)
	{
	}

	public void Hide()
	{
	}

	private int SetupRewardsAndReturnLikes(IReadOnlyDictionary<Match3Reward, int> inRewards)
	{
		return default(int);
	}

	private Match3UI_RewardItem CreateRewardItem(Match3Reward inReward, int inCount)
	{
		return null;
	}

	private void ClearRewards()
	{
	}

	public void BtnClicked_Quit()
	{
	}

	public void BtnClicked_PlayAgain()
	{
	}

	public void BtnClicked_PuzzleGallery()
	{
	}

	public void BtnClicked_PurchaseRetry()
	{
	}

	private void OnRetryPurchased(InventoryItemAddedEvent obj)
	{
	}

	public void BtnClicked_Continue()
	{
	}
}
