using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RunesResultsScreen : MonoBehaviour
{
	[Serializable]
	public class RuneResultsGroup
	{
		public ScrollRect scroll;

		public RunesRewardItemUI rewardItem;

		public GameObject noRewards;

		[NonSerialized]
		public List<RunesRewardItemUI> itemList;
	}

	public WWTextMeshProUGUI gameResultsLabel;

	public WWTextMeshProUGUI gameProgressLabel;

	public WWTextMeshProUGUI scoreText;

	public WWTextMeshProUGUI likesText;

	public RuneResultsGroup allResults;

	public GameObject navigationBackground;

	public GameObject navigationButtonsContainer;

	public void SetupForGameProgress()
	{
	}

	public void SetupForGameResults()
	{
	}

	public void SetScoreText(int inScore)
	{
	}

	public void SetLikesText(int inLikes)
	{
	}

	public void SetRewards(List<RunesReward> inReward)
	{
	}

	public void ClearResults()
	{
	}
}
