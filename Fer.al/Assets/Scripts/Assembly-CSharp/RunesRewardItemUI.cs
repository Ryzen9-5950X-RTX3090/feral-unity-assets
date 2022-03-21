using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RunesRewardItemUI : MonoBehaviour
{
	public RawImage rewardIcon;

	public GameObject rewardCountContainer;

	public WWTextMeshProUGUI rewardCountText;

	public WWTextMeshProUGUI rewardName;

	private void OnDestroy()
	{
	}

	public void SetIcon(string inRewardItemId)
	{
	}

	public void SetRewardCount(int inCount)
	{
	}

	public void SetRewardName(string inLocalizedName)
	{
	}
}
