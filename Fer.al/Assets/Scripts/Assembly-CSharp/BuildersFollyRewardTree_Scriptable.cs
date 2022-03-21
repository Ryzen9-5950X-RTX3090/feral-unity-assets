using UnityEngine;

public class BuildersFollyRewardTree_Scriptable : ScriptableObject
{
	public enum ERewardTreeCategory
	{
		Likes,
		Clothing,
		Dye,
		Furniture,
		Ingredients
	}

	public string rewardTreeName;

	public Sprite rewardTreeImage;

	public ERewardTreeCategory rewardTreeCategory;
}
