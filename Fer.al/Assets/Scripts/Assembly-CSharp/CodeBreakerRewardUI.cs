using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CodeBreakerRewardUI : MonoBehaviour
{
	[Serializable]
	public class CodeBreakerReward
	{
		public GameObject container;

		public RawImage icon;

		public GameObject countContainer;

		public WWTextMeshProUGUI countText;

		public WWTextMeshProUGUI itemName;
	}

	public GameObject noRewardContainer;

	public List<CodeBreakerReward> rewards;

	private int _rewardCount;

	public void OnMinigamePrizeGiven(MinigamePrizeGiven inMessage)
	{
	}

	private void SetReward(int inIndex, string inRewardDefId, int inCount)
	{
	}

	public void ClearRewards()
	{
	}
}
